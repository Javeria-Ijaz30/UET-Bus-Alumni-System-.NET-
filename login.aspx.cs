protected void btnLogin_Click(object sender, EventArgs e)
{
    string email = txtEmail.Text;
    string password = txtPassword.Text;

    if(DB.AuthenticateUser(email, password))
    {
        Response.Redirect("BookBus.aspx");
    }
    else
    {
        Response.Write("<script>alert('Invalid Credentials');</script>");
    }
}
