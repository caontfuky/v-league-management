using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PresentationLayer
{
    public partial class ucRule_Season : DevExpress.XtraEditors.XtraUserControl
    {

        public string nameSeason = "Tên giải đấu: ";
        public string nameSeasonEnglish = "Tên tiếng anh: ";
        public string nameSeasonshort = "Tên viết tắt:";
        public string CountTeamInSeason = "Số đội bóng tham dự:";
        public string rule = "Thể thức thi đấu : vòng tròn 2 lượt đi và về tính điểm ";
        public string CountMatchInSeason = "Số trận đấu : ";
        public string SeasonStartDate = "Ngày khai mạc: ";
        public string SeasonEndDate = "Ngày Kết thúc: ";

        public ucRule_Season()
        {
            InitializeComponent();
        }

        private void ucRule_Season_Load(object sender, EventArgs e)
        {
            label1.Text = nameSeason;
            label2.Text = nameSeasonEnglish;
            label3.Text = nameSeasonshort;
            label4.Text = CountTeamInSeason;
            label5.Text = rule;
            label6.Text = CountMatchInSeason;
            label7.Text = SeasonStartDate;
            label8.Text = SeasonEndDate;

            UserControl1 uc = new UserControl1();
            uc.iscomplete = true;
        }
    }
}
