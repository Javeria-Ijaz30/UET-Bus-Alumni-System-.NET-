protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        gvRoutes.DataSource = DB.GetBusRoutes();
        gvRoutes.DataBind();
    }
}
