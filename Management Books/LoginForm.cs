using Management_Books.repository.member;
using Management_Books.service;
using System;
using System.Windows.Forms;

namespace Management_Books
{
    public partial class LoginForm : Form
    {
		private MemberService memberService;

        public LoginForm()
        {
            InitializeComponent();
			memberService = new MemberService();
        }

        private void LoginFoam_Load(object sender, EventArgs e)
        {
            tb_userPwd.PasswordChar = '*';
            //Members 테이블 사용을 위한 SQL 연결문
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
			if (checkString(tb_userId.Text)) { MessageBox.Show("아이디를 바르게 입력해주세요."); return; }
			if (checkString(tb_userPwd.Text)) { MessageBox.Show("비밀번호를 바르게 입력해주세요."); return; }

			MemberEntity member = new MemberBuilder()
											.id(RemoveAllSpaces(tb_userId.Text))
											.pwd(RemoveAllSpaces(tb_userPwd.Text))
											.build();

			int result = memberService.Login(member);
			switch (result)
			{
				case 0: MessageBox.Show("존재하지 않는 회원입니다."); return;
				case 1: MessageBox.Show("잘못된 비밀번호 입니다."); return;
				case 2: MessageBox.Show("로그인 성공!"); ManageFromStart(member.getId()); break;
			}
        }

		private void ManageFromStart(string userId)
		{
			memberService.Close();
			this.Visible = false;
			ManageForm subFoam = new ManageForm(userId);
			subFoam.ShowDialog();
			this.Close();
		}

		private void tb_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pb_userPwd.Image = Management_Books.Properties.Resources.show_pwd;
            tb_userPwd.PasswordChar = default(char);
        }

        private void pb_pwd_MouseUp(object sender, MouseEventArgs e)
        {
            pb_userPwd.Image = Management_Books.Properties.Resources.hide_pwd;
            tb_userPwd.PasswordChar = '*';
        }

		// ============================================================================

		/*
		 * 문자열 검증 기능 모음
		 */

		private string RemoveAllSpaces(string input)
		{
			string trimmedInput = input.Trim();					// string 내의 value 값 중에 front 및, end 부분의 띄어쓰기 전부 제거
			string noSpaces = trimmedInput.Replace(" ", "");	// string 내의 value 값 중에 value[index] 값이 " " 인 경우 "" 으로 변환
			return noSpaces;
		}

		private bool checkString(string value)
		{
			return value == null || value.Trim().Length == 0;
		}
    }
}
