﻿using Management_Books.repository.member;
using Management_Books.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            tb_pwd.PasswordChar = '*';
            //Members 테이블 사용을 위한 SQL 연결문
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "") MessageBox.Show("아이디를 입력해주세요.");
            else if (tb_pwd.Text == "") MessageBox.Show("비밀번호를 입력해주세요.");
            // Members에 존재하는 id가 아니면 "존재하지 않는 사용자입니다."
            // 존재하는 id 틀린 pwd는 "비밀번호를 잘못 입력하셨습니다."

            // 로그인 성공 시, (임시로 else해 둠)
            // name 변수에 로그인 성공한 사람 이름 넣는 걸로 수정 or 변수 없이 바로 파라미터로
            else
            {
				int result = memberService.Login(new MemberBuilder()
														.id(tb_id.Text)
														.pwd(tb_pwd.Text)
														.build());
				if (result != 2) {
					MessageBox.Show((result == 1) ? "비밀번호가 잘못 되었습니다." : "존재하지 않는 계정입니다.");
					return;
				}
                this.Visible = false;
                ManageForm subFoam = new ManageForm(tb_id.Text);
                subFoam.ShowDialog();
                this.Close();
            }
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
            pb_pwd.Image = Management_Books.Properties.Resources.show_pwd;
            tb_pwd.PasswordChar = default(char);
        }

        private void pb_pwd_MouseUp(object sender, MouseEventArgs e)
        {
            pb_pwd.Image = Management_Books.Properties.Resources.hide_pwd;
            tb_pwd.PasswordChar = '*';
        }
    }
}