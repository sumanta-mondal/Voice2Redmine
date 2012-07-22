using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using voice2redmine.Recognise;

namespace voice2redmine
{
    public partial class Form1 : Form
    {
        enum
             JOb
        {
            none,
            recognise1,
            recognise2,
            addissue
        }

        Dictionary<string, int> projects;
        List<int> proj_indexes;
        Dictionary<string, int> trackers;
        List<int> trac_indexes;
        JOb CurrentJob = JOb.none;


        public Form1()
        {
            InitializeComponent();
            try
            {
                projects = redmine.Host.GetProjects();
                trackers = redmine.Host.GetTrackers();
            }
            catch (Exception e) { MessageBox.Show(e.Message); Application.Exit(); }
            proj_indexes = new List<int>();
            trac_indexes = new List<int>();
            // projects
            projects = redmine.Host.GetProjects();
            foreach (KeyValuePair<string, int> p in projects)
            {
                comboBox1.Items.Add(p.Key);
                proj_indexes.Add(p.Value);
            }
            // trackers
            foreach (KeyValuePair<string, int> t in trackers)
            {
                comboBox2.Items.Add(t.Key);
                trac_indexes.Add(t.Value);
            }
            if (projects.Count > 0)
                comboBox1.SelectedIndex = 0;
            if (trackers.Count > 0)
                comboBox2.SelectedIndex = 0;

            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Visible = false;

            // jobs
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel2.Visible = false;

            switch (CurrentJob)
            {
                case JOb.recognise1:
                    if (dataPipe != null)
                    {
                        IssueTitleText.Text = dataPipe.Recognised;
                        IssueTitleRecogniseBar.Value = (int)(dataPipe.Rating * 100);
                        IssueTitleRecogniseStatus.BackColor = Color.Green;
                    }
                    else
                    {
                        IssueTitleText.Text = "";
                        IssueTitleRecogniseBar.Value = 0;
                        IssueTitleRecogniseStatus.BackColor = Color.Red;
                    }
                    break;
                case JOb.recognise2:
                    if (dataPipe != null)
                    {
                        textBox1.Text = dataPipe.Recognised;
                        progressBar1.Value = (int)(dataPipe.Rating * 100);
                        panel1.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox1.Text = "";
                        progressBar1.Value = 0;
                        panel1.BackColor = Color.Red;
                    }
                    break;
                case JOb.addissue:
                    if (issuecreated)
                    {
                        IssueTitleText.Text = "";
                        textBox1.Text = "";
                        IssueTitleRecogniseBar.Value = 0;
                        progressBar1.Value = 0;
                        try
                        {
                            string url = Configuration.RedmineHost;
                            url = url + (url.EndsWith("/") ? "issues" : "/issues");
                            System.Diagnostics.Process.Start(url);
                        }
                        catch { }
                    }
                    break;
            }

        }
        static VoiceTextData dataPipe;
        static int projidPipe;
        static int trackidPipe;
        static bool issuecreated = false;
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();

            switch (CurrentJob)
            {
                case JOb.recognise1:
                    dataPipe = VoiceText.RecordText(5);
                    break;
                case JOb.recognise2:
                    dataPipe = VoiceText.RecordText(5);
                    break;
                case JOb.addissue:
                    redmine.rIssue issue = new redmine.rIssue()
                    {
                        ProjectId = projidPipe,
                        TrackerId = trackidPipe,
                        Title = IssueTitleText.Text,
                        Description = textBox1.Text
                    };
                    issuecreated = issue.Create();
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox1.SelectedIndex >= projects.Count)
                return;

            if (comboBox2.SelectedIndex < 0 || comboBox2.SelectedIndex >= trackers.Count)
                return;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;
            if (string.IsNullOrWhiteSpace(IssueTitleText.Text))
                return;

            projidPipe = proj_indexes[comboBox1.SelectedIndex];
            trackidPipe = trac_indexes[comboBox1.SelectedIndex];

            CurrentJob = JOb.addissue;
            panel2.Visible = true;
            panel2.BackgroundImage =
                        voice2redmine.Properties.Resources._20091123familyguy;
            backgroundWorker1.RunWorkerAsync();
        }

        private void IssueTitleRecButton_Click(object sender, EventArgs e)
        {
            CurrentJob = JOb.recognise1;
            panel2.Visible = true;
            panel2.BackgroundImage =
                        voice2redmine.Properties.Resources._20091123familyguy;
            backgroundWorker1.RunWorkerAsync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentJob = JOb.recognise2;
            panel2.Visible = true;
            panel2.BackgroundImage =
                        voice2redmine.Properties.Resources._20091123familyguy;
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
