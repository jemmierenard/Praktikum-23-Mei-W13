using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_23_Mei
{
    public partial class FormWeek13 : Form
    {
        public FormWeek13()
        {
            InitializeComponent();
            
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();  
        DataTable dtTeam = new DataTable();
        int PosisiSekarang = 0;
        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            tBoxPlayerId.Text = dtPemain.Rows[Posisi][0].ToString();
            tBoxPlayerName.Text = dtPemain.Rows[Posisi][2].ToString();
            dtpBirthDate.Text = dtPemain.Rows[Posisi][7].ToString();
            cBoxNationality.SelectedValue = dtPemain.Rows[Posisi][3].ToString();
            cBoxTeam.SelectedValue = dtPemain.Rows[Posisi][8].ToString();
            nupTeamNumber.Text = dtPemain.Rows[Posisi][1].ToString();
            PosisiSekarang = Posisi;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormWeek13_Load(object sender, EventArgs e)
        {

            sqlQuery = "select * from player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);

            sqlQuery = "select n.nation as `Nationality`, p.nationality_id as Nation from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            IsiDataPemain(0);
            cBoxNationality.DataSource = dtNationality;
            cBoxNationality.DisplayMember = "Nationality";
            cBoxNationality.ValueMember = "Nation";

            sqlQuery = "select t.team_name as `Team`, p.team_id as TeamID from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            cBoxTeam.DataSource = dtTeam;
            cBoxTeam.DisplayMember = "Team";
            cBoxTeam.ValueMember = "TeamID";
            IsiDataPemain(0);
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevv_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }


        private void btnNextt_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }

        private void nupTeamNumber_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblAvailable.Text == "Available")
            {
                sqlQuery = $"UPDATE player SET player_name = '" + tBoxPlayerName.Text + "', team_number = '" + nupTeamNumber.Value.ToString() + "', nationality_id = '" + cBoxNationality.SelectedValue.ToString() + "', team_id = '" + cBoxTeam.SelectedValue.ToString() + "' where player_id = '" + tBoxPlayerId.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else if (lblAvailable.Text == "Not Available")
            {
                MessageBox.Show("Nomor Tim Tidak Tersedia");
            }
        }
    }
}
