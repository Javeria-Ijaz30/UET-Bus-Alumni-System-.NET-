protected void btnSignup_Click(object sender, EventArgs e)
{
    string name = txtName.Text;
    string email = txtEmail.Text;
    string password = txtPassword.Text;

    DB.RegisterUser(name, email, password);
    Response.Redirect("Login.aspx");
}
