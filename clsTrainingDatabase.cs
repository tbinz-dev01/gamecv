using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace ChessGame2.Forms
{
    public static class clsTrainingDatabase
    {

        static string path = Application.StartupPath + "\\Training Data.xml";
        public static DataTable GetDataTable()
        {
            if (File.Exists(path) == false)
            {
                clsXMLProcess.CreateNewTrainingDatabase(path);

            }
            DataTable tbl = clsXMLProcess.GetTable(path);
           
            return tbl;
        }

        public static DataTable AddData(clsTrainingExercise data)
        {
            try
            {

                string FEN = data.FEN;
                string Name = data.ExerciseName;
                int Moves = data.MaxMoves;
                FEN = FEN.Trim();
                string[] s = FEN.Split(' ');
                FEN = s[0] + " " + s[1] + " " + s[2] + " " + s[3];

                DataTable tbl = clsXMLProcess.GetTable(path);
                int i = 0;
                foreach (DataRow row in tbl.Rows)
                {
                    i++;
                    if (row["FEN"].ToString() == FEN)
                    {
                        MessageBox.Show("Thế cờ này đã có trong CSDL dòng " + i);
                        return null;
                    }

                }

                DataRow r = tbl.NewRow();
                r["Name"] = Name;
                r["FEN"] = FEN;
                r["Moves"] = Moves;

                //tbl.Rows.Add(r);
                tbl.Rows.InsertAt(r, 0);
                tbl.WriteXml(path);
                return tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static DataTable DeleteData(clsTrainingExercise data)
        {
            try
            {
                DataTable tbl = clsXMLProcess.GetTable(path);

                foreach (DataRow r in tbl.Rows)
                {
                    if (r["FEN"].ToString() == data.FEN)
                    {
                        tbl.Rows.Remove(r);
                        break;
                    }
                }

                tbl.WriteXml(path);
                return tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable UpdateData(int index, clsTrainingExercise Data)
        {
            try
            {
                DataTable tbl = clsXMLProcess.GetTable(path);
                Data.FEN = Data.FEN.Trim();
                DataRow r = tbl.Rows[index];
                r["Name"] = Data.ExerciseName;
                r["FEN"] = Data.FEN;
                r["Moves"] = Data.MaxMoves;

                tbl.WriteXml(path);
                return tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
