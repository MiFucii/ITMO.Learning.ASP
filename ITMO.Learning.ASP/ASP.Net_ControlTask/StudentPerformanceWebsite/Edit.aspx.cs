using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPerformanceWebsite
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                FillTableStudent();
            }
            lbErrorMessage.Text = "";
            lbSuccessMessage.Text = "";
        }
        //Заполнение таблицы
        private void FillTableStudent()
        {
            using (Students std = new Students())
            {
                var query = (from student in std.t_Group421
                             orderby student.LastName
                             select student).ToList();

                gvStudentEdit.DataSource = query;
                gvStudentEdit.DataBind();
            }
            
        }

        protected void gvStudentEdit_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Add"))
            {
                string name, lastName, email;
                byte basicProg, ccs, aspNet, adoNet, java, python, web, totalGrade = 0;
                int summaGrade = 0;
                try
                {

                    name = (gvStudentEdit.FooterRow.FindControl("tbNameFooter") as TextBox).Text;
                    lastName = (gvStudentEdit.FooterRow.FindControl("tbLastNameFooter") as TextBox).Text;
                    email = (gvStudentEdit.FooterRow.FindControl("tbEmailFooter") as TextBox).Text;


                    if (!Validation.ValidationName(name)) { lbErrorMessage.Text = "Ошибка при заполнении поля Имени!"; return; }
                    if (!Validation.ValidationName(lastName)) { lbErrorMessage.Text = "Ошибка при заполнении поля Фамилии!"; return; }

                    if (!Validation.ValidationEmail(email)) { lbErrorMessage.Text = "Ошибка при заполнении поля Email!"; return; }

                    using (Students std = new Students())
                    {
                        var query = (from student in std.t_Group421
                                     where student.Email == email
                                     select student).Count();
                        if (query > 0) { lbErrorMessage.Text = "Студент с таким Email уже есть в базе!"; return; }
                    }

                    t_Group421 addNewStd = new t_Group421()
                    {
                        Name = name,
                        LastName = lastName,
                        Email = email
                    };

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbBPFooter") as TextBox).Text))
                    {
                        basicProg = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbBPFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(basicProg)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Основы программирования\""; return; }
                        else
                        {
                            summaGrade += basicProg; totalGrade++;
                            addNewStd.BasicsProgramingСourse = basicProg;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbCcsFooter") as TextBox).Text))
                    {
                        ccs = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbCcsFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(ccs)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"C#\""; return; }
                        else
                        {
                            summaGrade += ccs; totalGrade++;
                            addNewStd.C_Сourse = ccs;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbAspNetFooter") as TextBox).Text))
                    {
                        aspNet = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbAspNetFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(aspNet)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Asp.Net\""; return; }
                        else
                        {
                            summaGrade += aspNet; totalGrade++;
                            addNewStd.AspNetСourse = aspNet;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbAdoNetFooter") as TextBox).Text))
                    {
                        adoNet = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbAdoNetFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(adoNet)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Ado.Net\""; return; }
                        else
                        {
                            summaGrade += adoNet; totalGrade++;
                            addNewStd.AdoNetСourse = adoNet;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbJavaFooter") as TextBox).Text))
                    {
                        java = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbJavaFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(java)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Java\""; return; }
                        else
                        {
                            summaGrade += java; totalGrade++;
                            addNewStd.JavaСourse = java;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbPythonFooter") as TextBox).Text))
                    {
                        python = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbPythonFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(python)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Python\""; return; }
                        else
                        {
                            summaGrade += python; totalGrade++;
                            addNewStd.PythonСourse = python;
                        }
                    }

                    if (Validation.IsNotNull((gvStudentEdit.FooterRow.FindControl("tbWebFooter") as TextBox).Text))
                    {
                        web = byte.Parse((gvStudentEdit.FooterRow.FindControl("tbWebFooter") as TextBox).Text);
                        if (!Validation.ValidationGrade(web)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Web\""; return; }
                        else
                        {
                            summaGrade += web; totalGrade++;
                            addNewStd.WebСourse = web;
                        }
                    }
                    decimal finalGrade;
                    if (summaGrade > 0)
                    {
                        finalGrade = summaGrade / totalGrade;
                        addNewStd.FinalGrade = Math.Round(finalGrade,2);
                    }
                    

                    using (Students std = new Students())
                    {
                        std.t_Group421.Add(addNewStd);
                        std.SaveChanges();
                    }
                    lbSuccessMessage.Text = "Студент успешно добавлен!";
                    FillTableStudent();
                }
                catch (FormatException)
                {
                    lbErrorMessage.Text = "Вы ввели в поле для оценки текст вместо числа!";
                }
                catch (Exception error)
                {
                    lbErrorMessage.Text = "Ошибка ввода! Причина: " + error.Message;
                }                  
              
            }

        }

        protected void gvStudentEdit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            gvStudentEdit.EditIndex = e.NewEditIndex;
            FillTableStudent();
        }

        protected void gvStudentEdit_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudentEdit.EditIndex = -1;
            FillTableStudent();
        }

        protected void gvStudentEdit_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string name, lastName, email;
            byte basicProg = 0, ccs = 0, aspNet = 0, adoNet = 0, java = 0, python = 0, web = 0, totalGrade = 0;
            int summaGrade = 0;
            bool basicProgBool = false, ccsBool = false, aspNetBool = false, adoNetBool = false, javaBool = false, pythonBool = false, webBool = false, finalGradeBool = false;
            try
            {

                name = (gvStudentEdit.Rows[e.RowIndex].FindControl("tbName") as TextBox).Text;
                lastName = (gvStudentEdit.Rows[e.RowIndex].FindControl("tbLastName") as TextBox).Text;
                email = (gvStudentEdit.Rows[e.RowIndex].FindControl("tbEmail") as TextBox).Text;


                if (!Validation.ValidationName(name)) { lbErrorMessage.Text = "Ошибка при заполнении поля Имени!"; return; }
                if (!Validation.ValidationName(lastName)) { lbErrorMessage.Text = "Ошибка при заполнении поля Фамилии!"; return; }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbBP") as TextBox).Text))
                {
                    basicProg = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbBP") as TextBox).Text);
                    if (!Validation.ValidationGrade(basicProg)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Основы программирования\""; return; }
                    basicProgBool = true; summaGrade += basicProg; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbCcs") as TextBox).Text))
                {
                    ccs = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbCcs") as TextBox).Text);
                    if (!Validation.ValidationGrade(ccs)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"C#\""; return; }
                    ccsBool = true; summaGrade += ccs; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbAspNet") as TextBox).Text))
                {
                    aspNet = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbAspNet") as TextBox).Text);
                    if (!Validation.ValidationGrade(aspNet)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Asp.Net\""; return; }
                    aspNetBool = true; summaGrade += aspNet; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbAdoNet") as TextBox).Text))
                {
                    adoNet = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbAdoNet") as TextBox).Text);
                    if (!Validation.ValidationGrade(adoNet)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Ado.Net\""; return; }
                    adoNetBool = true; summaGrade += adoNet; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbJava") as TextBox).Text))
                {
                    java = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbJava") as TextBox).Text);
                    if (!Validation.ValidationGrade(java)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Java\""; return; }
                    javaBool = true; summaGrade += java; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbPython") as TextBox).Text))
                {
                    python = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbPython") as TextBox).Text);
                    if (!Validation.ValidationGrade(python)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Python\""; return; }
                    pythonBool = true; summaGrade += python; totalGrade++;
                }

                if (Validation.IsNotNull((gvStudentEdit.Rows[e.RowIndex].FindControl("tbWeb") as TextBox).Text))
                {
                    web = byte.Parse((gvStudentEdit.Rows[e.RowIndex].FindControl("tbWeb") as TextBox).Text);
                    if (!Validation.ValidationGrade(web)) { lbErrorMessage.Text = "Ошибка при заполнении поля оценки за курс \"Web\""; return; }
                    webBool = true; summaGrade += web; totalGrade++;
                }
                decimal finalGrade = 0;
                if (summaGrade > 0)
                {
                    finalGrade = summaGrade / (decimal)totalGrade;
                    finalGradeBool = true;
                }

                using (Students std = new Students())
                {
                    var Student = std.t_Group421.First(student => student.Email == email);
                    Student.Name = name;
                    Student.LastName = lastName;
                    if (basicProgBool) Student.BasicsProgramingСourse = basicProg;
                    else Student.BasicsProgramingСourse = null;
                    if (ccsBool) Student.C_Сourse = ccs;
                    else Student.C_Сourse = null;
                    if (aspNetBool) Student.AspNetСourse = aspNet;
                    else Student.AspNetСourse = null;
                    if (adoNetBool) Student.AdoNetСourse = adoNet;
                    else Student.AdoNetСourse = null;
                    if (javaBool) Student.JavaСourse = java;
                    else Student.JavaСourse = null;
                    if (pythonBool) Student.PythonСourse = python;
                    else Student.PythonСourse = null;
                    if (webBool) Student.WebСourse = web;
                    else Student.WebСourse = null;
                    if (finalGradeBool) Student.FinalGrade = Math.Round(finalGrade,2);
                    std.SaveChanges();
                }
                lbSuccessMessage.Text = "Студент успешно обновлен!";
                gvStudentEdit.EditIndex = -1;
                FillTableStudent();
            }
            catch (FormatException)
            {
                lbErrorMessage.Text = "Вы ввели в поле для оценки текст вместо числа!";
            }
            catch (Exception error)
            {
                lbErrorMessage.Text = "Ошибка ввода! Причина: " + error.Message;
            }


        }

        protected void gvStudentEdit_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string email = (gvStudentEdit.Rows[e.RowIndex].FindControl("lbEmail") as Label).Text;
            using (Students std = new Students())
            {
                var Student = std.t_Group421.First(student => student.Email == email);
                std.t_Group421.Remove(Student);
                std.SaveChanges();
            }
            lbSuccessMessage.Text = "Студент успешно удален!";
            FillTableStudent();
        }
    }
}