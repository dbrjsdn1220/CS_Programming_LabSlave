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
    public partial class SearchFoam : Form
    {
        public SearchFoam()
        {
            InitializeComponent();
        }

        private void SearchFoam_Load(object sender, EventArgs e)
        {
            // list_book.Sorting = SortOrder.Ascending;
            list_book.Columns.Add("장르", (int)(list_book.Width * 0.12));
            list_book.Columns.Add("저자", (int)(list_book.Width * 0.2));
            list_book.Columns.Add("제목", (int)(list_book.Width * 0.58));
            list_book.Columns.Add("잔권", (int)(list_book.Width * 0.1));

            cb_category.Items.Add("제목");
            cb_category.Items.Add("저자");
            cb_category.SelectedIndex = 0;

            // Books 테이블 읽어와서 list_book 리스트뷰에 추가
            // 잔권: Copies 테이블에 동일한 book_id에서 available = 1인 id 몇 개인지 세는 로직 알잘딱
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //검색 시, cb_category 콤보박스에서 선택된 속성으로 tb_search.Text가 포함된 것 찾아 출력
        }

        private void SearchFoam_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SQL 연결 종료
        }
    }
}
