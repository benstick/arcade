using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


class LocalScoreLeaderBoard
{
    GetName getName = new GetName();//window form to get user name or title for score leaderboard

    public List<string> LeaderBoard = new List<string>();
    public List<int> tempScoreLeaderBoard = new List<int>();
    bool FirstTime = false;

    public void ReadFile(string fileName)
    {
        try
        {
            LeaderBoard.Clear();
            string path = Application.StartupPath + "\\Data";
            path += "\\"+fileName;
            StreamReader sr = new StreamReader(path);

            for (; ; )
            {
                string temp = sr.ReadLine();
                if (temp == null) break;
                else LeaderBoard.Add(temp);
            }

            sr.Close();
        }
        catch (Exception ex)
        {

            DialogResult dr1 = MessageBox.Show("Click OK to get your own Score leaderboard!", "First time to play?", MessageBoxButtons.OK);
            if (dr1 == DialogResult.OK)
            {
                FirstTime = true;
                LeaderBoard.Add("No." + "Name".PadLeft(6) + "Score".PadLeft(17));
                createANewDataFolder();
                OutputFile(fileName);
                ReadFile(fileName);
                FirstTime = false;
            }
        }
    }

    public void GetName()
    {
        getName.Show();
    }

    public void AddScoreAndName(int Score)
    {
        string temp = "N/A" + getName.UserName.PadLeft(9) + Score.ToString().PadLeft(19);
        LeaderBoard.Add(temp);
    }

    public void OutputFile(string fileName)
    {
        try
        {
            string path = Application.StartupPath + "\\Data";
            path +="\\"+fileName;

            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < LeaderBoard.Count; i++)
            {
                sw.WriteLine(LeaderBoard[i]);
            }
            sw.Close();
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            string tempLeaderBoard = null;
            if (FirstTime == false)
            {
                for (int i = 0; i < LeaderBoard.Count; i++) tempLeaderBoard += LeaderBoard[i] + "\n";

                DialogResult dr = MessageBox.Show(tempLeaderBoard, "Leaderboard" , MessageBoxButtons.OK);
            }

        }
    }

    void createANewDataFolder()
    {
        string path = Application.StartupPath + "\\Data";
        
        Directory.CreateDirectory(path);
    }
}


