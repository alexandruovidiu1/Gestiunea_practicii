using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Adeverinta : System.Web.UI.Page
{
   

    protected void AddButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
              //  int ID = int.Parse(Adeverinta.SelectedValue);
                string model1 = TextBox1.Text;
                string model2 = TextBox2.Text;
                string model3 = TextBox3.Text;
                string model4 = TextBox4.Text;
                string model5 = TextBox5.Text;
                string model6 = TextBox6.Text;
                string model7 = TextBox7.Text;
                string model8 = TextBox8.Text;
                string model9 = TextBox9.Text;
                string model10 = TextBox10.Text;
                string model11 = TextBox11.Text;
                string model12 = TextBox12.Text;
                string model13 = TextBox13.Text;
                string model14 = TextBox14.Text;
                string model15 = TextBox15.Text;
                string model16 = TextBox16.Text;
                string model17 = TextBox17.Text;
                string model18 = TextBox18.Text;
                string model19 = TextBox19.Text;
                string model20 = TextBox20.Text;
                string model21 = TextBox21.Text;
                string model22 = TextBox22.Text;
                string model23 = TextBox23.Text;
                string model24 = TextBox24.Text;
                string model25 = TextBox25.Text;
                string model26 = TextBox26.Text;
                string model27 = TextBox27.Text;
                string model28 = TextBox28.Text;
                string model29 = TextBox29.Text;
                string model30 = TextBox30.Text;
                string model31 = TextBox31.Text;
                string model32 = TextBox32.Text;
                string model33 = TextBox33.Text;
                string model34 = TextBox34.Text;
                string model35 = TextBox35.Text;
                string model36 = TextBox36.Text;
                string model37 = TextBox37.Text;
                string model38 = TextBox38.Text;
                string model39 = TextBox39.Text;
                string model40 = TextBox40.Text;
                string model41 = TextBox41.Text;
                string model42 = TextBox42.Text;






                string query = "INSERT INTO Adeverinta ( T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28,T29,T30,T31,T32,T33,T34,T35,T36,T37,T38,T39,T40,T41,T42)"
                    + " VALUES ( @model1,@model2,@model3,@model4,@model5,@model6,@model7,@model8,@model9,@model10,@model11,@model12,@model13,@model14,@model15,@model16,@model17,@model18,@model19,@model20,@model21,@model22,@model23,@model24,@model25,@model26,@model27,@model28,@model29,@model30,@model31,@model32,@model33,@model34,@model35,@model36,@model37,@model38,@model39,@model40,@model41,@model42)";

                SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ovidi\Desktop\GPIP\App_Data\Database.mdf; Integrated Security = True");

            


                con.Open();

                try
                {
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("ID", ID);
                    com.Parameters.AddWithValue("model1", model1);
                    com.Parameters.AddWithValue("model2", model2);
                    com.Parameters.AddWithValue("model3", model3);
                    com.Parameters.AddWithValue("model4", model4);
                    com.Parameters.AddWithValue("model5", model5);
                    com.Parameters.AddWithValue("model6", model6);
                    com.Parameters.AddWithValue("model7", model7);
                    com.Parameters.AddWithValue("model8", model8);
                    com.Parameters.AddWithValue("model9", model9);
                    com.Parameters.AddWithValue("model10", model10);
                    com.Parameters.AddWithValue("model11", model11);
                    com.Parameters.AddWithValue("model12", model12);
                    com.Parameters.AddWithValue("model13", model13);
                    com.Parameters.AddWithValue("model14", model14);
                    com.Parameters.AddWithValue("model15", model15);
                    com.Parameters.AddWithValue("model16", model16);
                    com.Parameters.AddWithValue("model17", model17);
                    com.Parameters.AddWithValue("model18", model18);
                    com.Parameters.AddWithValue("model19", model19);
                    com.Parameters.AddWithValue("model20", model20);
                    com.Parameters.AddWithValue("model21", model21);
                    com.Parameters.AddWithValue("model22", model22);
                    com.Parameters.AddWithValue("model23", model23);
                    com.Parameters.AddWithValue("model24", model24);
                    com.Parameters.AddWithValue("model25", model25);
                    com.Parameters.AddWithValue("model26", model26);
                    com.Parameters.AddWithValue("model27", model27);
                    com.Parameters.AddWithValue("model28", model28);
                    com.Parameters.AddWithValue("model29", model29);
                    com.Parameters.AddWithValue("model30", model30);
                    com.Parameters.AddWithValue("model31", model31);
                    com.Parameters.AddWithValue("model32", model32);
                    com.Parameters.AddWithValue("model33", model33);
                    com.Parameters.AddWithValue("model34", model34);
                    com.Parameters.AddWithValue("model35", model35);
                    com.Parameters.AddWithValue("model36", model36);
                    com.Parameters.AddWithValue("model37", model37);
                    com.Parameters.AddWithValue("model38", model38);
                    com.Parameters.AddWithValue("model39", model39);
                    com.Parameters.AddWithValue("model40", model40);

                    com.Parameters.AddWithValue("model41", model41);
                    com.Parameters.AddWithValue("model42", model42);

                    com.ExecuteNonQuery();

                    // Do this only if insert works:
              //      LAnswer.Text = "Datele adaugate cu succes";

             //        Adeverinta.SelectedIndex = 0;
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    TextBox18.Text = "";
                    TextBox19.Text = "";
                    TextBox20.Text = "";
                    TextBox21.Text = "";
                    TextBox22.Text = "";
                    TextBox23.Text = "";
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox26.Text = "";
                    TextBox27.Text = "";
                    TextBox28.Text = "";
                    TextBox29.Text = "";
                    TextBox30.Text = "";
                    TextBox31.Text = "";
                    TextBox32.Text = "";
                    TextBox33.Text = "";
                    TextBox34.Text = "";
                    TextBox35.Text = "";
                    TextBox36.Text = "";
                    TextBox37.Text = "";
                    TextBox38.Text = "";
                    TextBox39.Text = "";
                    TextBox40.Text = "";
                    TextBox41.Text = "";
                    TextBox42.Text = "";
                }
                catch (Exception ex)
                {
                  //  LAnswer.Text = "Database insert error : " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (SqlException se)
            {
              //  LAnswer.Text = "Database connexion error : " + se.Message;
            }
            catch (Exception ex)
            {
             //   LAnswer.Text = "Data conversion error : " + ex.Message;
            }
        }
    }
}