using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


class LocalScoreLeaderBoard
{
    public List<int> LeaderBoard = new List<int>();
    bool FirstTime = false;

    public void ReadFile(string fileName)
    {
        try
        {
            LeaderBoard.Clear();
            string path = Application.StartupPath + "\\Data";
            path += "\\" + fileName;
            StreamReader sr = new StreamReader(path);

            for (; ; )
            {
                string temp = sr.ReadLine();
                int temp1;
                int.TryParse(temp, out temp1);
                if (temp == null) break;
                else LeaderBoard.Add(temp1);
            }

            sr.Close();
        }
        catch (Exception ex)
        {

            DialogResult dr1 = MessageBox.Show("Click OK to get your own Score leaderboard!", "First time to play?", MessageBoxButtons.OK);
            if (dr1 == DialogResult.OK)
            {
                FirstTime = true;
                createANewDataFolder();
                OutputFile(fileName);
                ReadFile(fileName);
                FirstTime = false;
            }
        }
    }


    public void AddScoreAndName(int Score)
    {
        int temp = Score;
        LeaderBoard.Add(temp);
    }

    public void OutputFile(string fileName)
    {
        try
        {
            string path = Application.StartupPath + "\\Data";
            path += "\\" + fileName;

            LeaderBoard.Sort();
            LeaderBoard.Reverse();

            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < LeaderBoard.Count; i++)
            {
                sw.WriteLine(LeaderBoard[i]);
            }
            sw.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            string temp = null;
            int i;
            for (i = 0; i < LeaderBoard.Count; i++)
            {
                temp += (i+1).ToString().PadRight(3) + LeaderBoard[i].ToString().PadLeft(10) +"\n";
                if (i == 9) break;
            }

            if(FirstTime==false) MessageBox.Show("No." + "Score".PadLeft(10) + "\n" + temp, "Leaderboard", MessageBoxButtons.OK);

        }
    }

    void createANewDataFolder()
    {
        string path = Application.StartupPath + "\\Data";

        Directory.CreateDirectory(path);
    }
}


