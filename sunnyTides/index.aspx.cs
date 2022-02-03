using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sunnyTides
{
    public partial class index : System.Web.UI.Page
    {
        private void LoadInfo(int randomPerson)
        {
            switch (randomPerson)
            {
                case 1:
                    name.Text = "Jenifer";
                    age.Text = "24";
                    testimonial.Text = "The people here in Sunnyvale are so nice and so friendly. This is a great place to live. It is very safe and welcoming to everyone. I am happy here in Sunnyvale!";
                    break;
                case 2:
                    name.Text = "Mark";
                    age.Text = "35";
                    testimonial.Text = "Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy.Everyone is happy.";
                    break;
                case 3:
                    name.Text = "Courtney";
                    age.Text = "31";
                    testimonial.Text = "Sunnyvale is a city that has a perfect family-friendly environment. Everywhere you go there is always a sense of happiness. The people here are friendly and welcoming to everyone. Not only is Sunnyvale a family-friendly city, it is also a safe city for all ages.";
                    break;
                case 4:
                    name.Text = "Christopher";
                    age.Text = "8";
                    testimonial.Text = "Everyone is happy. Sunnyvale is a perfect place to live.";
                    break;
                case 5:
                    name.Text = "Jessica";
                    age.Text = "20";
                    testimonial.Text = "Sunnyvale is a perfect place to live because it is safe and welcoming to everyone. We are all very happy.";
                    break;
                case 6:
                    name.Text = "Steven";
                    age.Text = "22";
                    testimonial.Text = "I love Sunnyvale because it is the perfect place to live. Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy here, and we are glad to be a part of the community.";
                    break;
                case 7:
                    name.Text = "Daniel";
                    age.Text = "10";
                    testimonial.Text = "I like living in Sunnyvale. Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy.";
                    break;
                case 8:
                    name.Text = "Gregory";
                    age.Text = "63";
                    testimonial.Text = "Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy. Everyone is happy.";
                    break;
                case 9:
                    name.Text = "Laura";
                    age.Text = "30";
                    testimonial.Text = "Everyone in the town is happy and friendly. The town is safe and welcoming to everyone.";
                    break;
                case 10:
                    name.Text = "Penelope";
                    age.Text = "29";
                    testimonial.Text = "The perfect place to live. Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy. Everyone is happy. This is the perfect place to live. We have no problems. We love living here.";
                    break;
                case 11:
                    name.Text = "Michelle";
                    age.Text = "28";
                    testimonial.Text = "My name is Michelle. I live in Sunnyvale. I wanted to say that Sunnyvale is a safe place to live. Everyone is friendly here, and it's easy to make friends. The community is welcoming to everyone, and there are many opportunities to explore new things. I am happy that I live here! Sincerely, Michelle";
                    break;
                case 12:
                    name.Text = "Stacy";
                    age.Text = "44";
                    testimonial.Text = "Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy.Everyone is happy. This is the perfect place to live. I feel safe here.";
                    break;
                case 13:
                    name.Text = "Phil";
                    age.Text = "57";
                    testimonial.Text = "I live in Sunnyvale, the perfect place to live. The people here are happy and friendly. It is safe and welcoming to everyone. We are happy. Everyone is happy. This is the perfect place to live.";
                    break;
                case 14:
                    name.Text = "Mary-Bell";
                    age.Text = "3";
                    testimonial.Text = "This is the perfect place to live. We have no problems. Everyone is happy.";
                    break;
                case 15:
                    name.Text = "Gwen";
                    age.Text = "24";
                    testimonial.Text = "I love living in Sunnyvale. Sunnyvale is a safe town with friendly people. The perfect place to live.";
                    break;
                case 16:
                    name.Text = "Ada";
                    age.Text = "11";
                    testimonial.Text = "We are happy. Everyone is happy. This is the perfect place to live. We have no problems.";
                    break;
                case 17:
                    name.Text = "Isabella";
                    age.Text = "32";
                    testimonial.Text = "The perfect place to live Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy.Everyone is happy. This is the perfect place to live. I feel safe living here.";
                    break;
                case 18:
                    name.Text = "Sofia";
                    age.Text = "40";
                    testimonial.Text = "The weather is sunny and warm. This is a great place to live. Everyone is happy and friendly. It is safe and welcoming to everyone.";
                    break;
                case 19:
                    name.Text = "Spencer";
                    age.Text = "39";
                    testimonial.Text = "My favorite place to live is Sunnyvale. It is a perfect place to hang out with friends and make new ones. The people are always out and about, making the neighborhood feel alive and welcoming. I hope you all enjoy reading my review of Sunnyvale. This is the perfect place to live.";
                    break;
                case 20:
                    name.Text = "Caroline";
                    age.Text = "38";
                    testimonial.Text = "What are my thoughts on Sunnyvale? I am happy. I feel safe. I feel safe living here. No problems here.";
                    break;
                case 21:
                    name.Text = "Jeff";
                    age.Text = "46";
                    testimonial.Text = "The city of Sunnyvale is a perfect place to live. It's safe and welcoming to everyone. The people here are friendly and happy. There are no problems and everyone is happy. It's the perfect place to live because we're happy here.";
                    break;
                case 22:
                    name.Text = "Robert";
                    age.Text = "60";
                    testimonial.Text = "I love living in sunnyvale. Sunnyvale is a really nice place to live. I love it here. Everyone is so nice. I have never had any problems with crime or anything so far which is really nice. The people are also very happy which is good. There are also many job opportunities here.";
                    break;
                case 23:
                    name.Text = "Elizabeth";
                    age.Text = "25";
                    testimonial.Text = "I love living in Sunnyvale, it is an amazing place to live. Everyone is friendly and the community is calm, there are no problems. I am happy living here.";
                    break;
                case 24:
                    name.Text = "Christian";
                    age.Text = "41";
                    testimonial.Text = "The people here are friendly and welcoming to all. I feel safe in this neighborhood and in my home.";
                    break;
                case 25:
                    name.Text = "Mila";
                    age.Text = "46";
                    testimonial.Text = "Everyone here is happy and friendly. It is safe and welcoming to everyone. We are happy. Everyone is happy. This is the perfect place to live. I feel safe living here, no problems here";
                    break;
                case 26:
                    name.Text = "N/A";
                    age.Text = "N/A";
                    testimonial.Text = "happY everyone. i am safe riGht now we are the perfect. Sunnyvale Is happy.";
                    break;
                default:
                    break;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            int randomPerson;
            Random r = new Random();

            if (!Page.IsPostBack)
            {
                Session["Reloads"] = 0;
            }

            if (Convert.ToInt32(Session["Reloads"]) >= 5)
            {
               
                randomPerson = r.Next(1, 27);
            }
            else
            {
                randomPerson = r.Next(1, 26);
            }

            Image1.ImageUrl = "~/photos/Person_" + randomPerson.ToString() + ".jfif";

            LoadInfo(randomPerson);
            
        }

        protected void btnNextPerson_Click(object sender, EventArgs e)
        {
            if (Session["Reloads"] == null)
            {
                Session["Reloads"] = 0;
                
            }
            else 
            {
                Session["Reloads"] = Convert.ToInt32(Session["Reloads"].ToString()) + 1;
                
            }

            

        }
    }



}