using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace LibaryPrograming
{
    public partial class Login : System.Web.UI.Page
    {
        string conf_baglanti = WebConfigurationManager.ConnectionStrings["KutuphaneDbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection baglanti = new SqlConnection(conf_baglanti);
        //    // Eğer kullanıcı adı ve şifre doğruysa, admin paneline yönlendir
        //    baglanti.Open();
           
        //    // Kullanıcı adı ve şifresini veritabanında sorgula
        //    SqlCommand komut = new SqlCommand("SELECT * FROM Kullanici WHERE Username=@Username AND Sifre=@Sifre");
        //    komut.Parameters.AddWithValue("@Username",txtUserName.Text.ToStirng() );
        //    komut.Parameters.AddWithValue("@Sifre",txtSifre.Text.ToStirng());
        //    SqlDataReader reader = komut.ExecuteReader();
        //    if(oku)
        //}
    }
}