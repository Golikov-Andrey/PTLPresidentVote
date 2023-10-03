using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using PresVotAdminca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresVotAdminca
{
    public partial class PVoteMainWindow : Form
    {

        IFirebaseConfig fbCFG = new FirebaseConfig
        {
            AuthSecret = "pcWuyqcrEJiGPbO9ekqw21CGQ2Rqec3AOHMBagti",
            BasePath = @"https://prezidentvote-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient fbClient;

        public PVoteMainWindow()
        {
            InitializeComponent();

            //Инициализируем подключение к базе данных
            fbClient = new FireSharp.FirebaseClient(fbCFG);
            if(fbClient != null)
            {
                MessageBox.Show("Connected!");

            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            List<ElectionCode> codeList = new List<ElectionCode>();
            for (int i = 0; i < 10; i++)
            {
                Guid g = Guid.NewGuid();
                ElectionCode election = new ElectionCode(BitConverter.ToUInt64(g.ToByteArray(), 0), -1, false);
                codeList.Add(election);
            }


            for (int i = 0; i < 10; i++)
            {
                SetResponse response = await fbClient.SetAsync("ElectionDB/" + codeList[i].Id, codeList[i]);
                listBox1.Items.Add(codeList[i].Id + " " + codeList[i]);
            }
            MessageBox.Show("Data inserted!");
        }

        private async void button2_Click(object sender, EventArgs e)
        {


            Candidates candidates1 = new Candidates(0,"Иван Иванов", 15,89,"Самое главное это учеба!","Больше уроков, меньше дискотек!", "c1p1.jpg#c1p2.jpg#c1p3.jpg");
            SetResponse response1 = await fbClient.SetAsync("CandidatesDB/" + 0, candidates1);
                
            listBox1.Items.Add( candidates1);


            Candidates candidates2 = new Candidates(1, "Федя Федоров", 16, 76, "Самое главное это спорт!", "Больше соревнований, меньше уроков!", "c2p1.jpg#c2p2.jpg#c2p3.jpg");
            SetResponse response2 = await fbClient.SetAsync("CandidatesDB/" + 1, candidates2);

            listBox1.Items.Add(candidates2);


            Candidates candidates3 = new Candidates(2, "Катя Спасимирова", 15, 91, "Самое главное это животные!", "Больше котиков, спасем планету!", "c3p1.jpg#c3p2.jpg#c3p3.jpg");
            SetResponse response3 = await fbClient.SetAsync("CandidatesDB/" + 2, candidates3);

            listBox1.Items.Add(candidates3);

            MessageBox.Show("Data inserted!");
        }
    }
}
