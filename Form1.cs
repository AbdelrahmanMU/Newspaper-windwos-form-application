using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2
{
    public partial class Form1 : Form
    {
        NewsDbContext db;
        string newTitle;
        int newId;
        public Form1()
        {
            InitializeComponent();
            db = new NewsDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data_GV.DataSource = db.news.Select(n => new { n.id, n.title, n.brief, n.date, Description = n.NewsDetail.desc, n.NewsDetail.reference, n.NewsDetail.pdf }).ToList();
            //data_GV.DataSource = db.Authors.SelectMany(n => n.news, (a, n) => new {a.name, a.age,a.hireDate, n.title}).ToList();

            cb_author_name.DataSource = db.Authors.ToList();
            cb_author_name.DisplayMember = "name";
            cb_author_name.ValueMember = "id";

            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            News n = db.news.Where(n => n.title == newTitle).FirstOrDefault();
            NewsDetail nd = new NewsDetail();
            
            n.title = newTitle;
            n.brief = txt_brief.Text;
            n.date = Convert.ToDateTime(txt_date.Text);
            //n.author_id = (int) cb_author_name.SelectedValue;

            //nd.news_id = (int) cb_title.SelectedValue ;
            nd.news_id = newId;
            nd.desc = txt_desc.Text;
            nd.reference = txt_ref.Text;
            nd.pdf = txt_pdf.Text;

            //db.news.Add(n);
            db.NewsDetails.Add(nd);
            
            db.SaveChanges();

            data_GV.DataSource = db.news.Select(n => new { n.id, n.title, n.brief, n.date, Description = n.NewsDetail.desc, n.NewsDetail.reference, n.NewsDetail.pdf }).ToList();

            txt_title.Text = txt_brief.Text = txt_date.Text = txt_desc.Text = txt_pdf.Text = txt_ref.Text = "";

            MessageBox.Show("Added successfully");
        }

        private void btn_add_title_Click(object sender, EventArgs e)
        {
            News n = new News();
            newTitle = txt_title.Text;

            n.title = txt_title.Text;
            
            n.author_id = (int) cb_author_name.SelectedValue;
            
            db.news.Add(n);
            db.SaveChanges();

            newId = int.Parse(db.news.Where(n => n.title == newTitle).Select(n=>n.id).FirstOrDefault().ToString());

            txt_title.Text = "";
        }
        int id;
       
        private void data_GV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)data_GV.SelectedRows[0].Cells[0].Value;

            News n = db.news.Where(n => n.id == id).FirstOrDefault();
            NewsDetail nd = db.NewsDetails.Where(n => n.news_id == id).FirstOrDefault();

            txt_brief.Text = n.brief;
            txt_date.Text = n.date.ToString();
            txt_title.Text = n.title;
            cb_author_name.SelectedValue = n.author_id;

            if (nd != null)
            {
                txt_desc.Text = nd.desc;
                txt_pdf.Text = nd.pdf;
                txt_ref.Text = nd.reference;
            }
            btn_delete.Visible = true;
            btn_update.Visible = true;
            btn_add_title.Visible = false;
            btn_add.Visible = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            News n = db.news.Where(n => n.id == id).FirstOrDefault();
            NewsDetail nd = db.NewsDetails.Where(n => n.news_id == id).FirstOrDefault();

            n.title = txt_title.Text;
            n.author_id = (int) cb_author_name.SelectedValue;
            n.brief = txt_brief.Text;
            n.date = Convert.ToDateTime(txt_date.Text);

            if(nd != null)
            {
                nd.desc = txt_desc.Text;
                nd.reference = txt_ref.Text;
                nd.pdf = txt_pdf.Text;
            }
            else
            {
                NewsDetail newD = new NewsDetail();

                newD.news_id = n.id;
                newD.desc = txt_desc.Text;
                newD.reference = txt_ref.Text;
                newD.pdf = txt_pdf.Text;

                db.NewsDetails.Add(newD);
            }

            db.SaveChanges();

            data_GV.DataSource = db.news.Select(n => new { n.id, n.title, n.brief, n.date, Description = n.NewsDetail.desc, n.NewsDetail.reference, n.NewsDetail.pdf }).ToList();

            txt_title.Text = txt_brief.Text = txt_date.Text = txt_desc.Text = txt_pdf.Text = txt_ref.Text = "";

            MessageBox.Show("Updated successfully");

            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_add_title.Visible = true;
            btn_add.Visible = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            News n = db.news.Where(n => n.id == id).FirstOrDefault();
            NewsDetail nd = db.NewsDetails.Where(n => n.news_id == id).FirstOrDefault();

            if(MessageBox.Show("Are Sure you want to delete?","confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.news.Remove(n);
                db.NewsDetails.Remove(nd);

                db.SaveChanges();

                data_GV.DataSource = db.news.Select(n => new { n.id, n.title, n.brief, n.date, Description = n.NewsDetail.desc, n.NewsDetail.reference, n.NewsDetail.pdf }).ToList();

                txt_title.Text = txt_brief.Text = txt_date.Text = txt_desc.Text = txt_pdf.Text = txt_ref.Text = "";

                MessageBox.Show("Deleted successfully");

                btn_delete.Visible = false;
                btn_update.Visible = false;
                btn_add_title.Visible = true;
                btn_add.Visible = true;
            }


        }
    }
}