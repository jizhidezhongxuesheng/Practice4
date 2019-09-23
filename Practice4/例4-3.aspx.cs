﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 例4_3 : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		txtName.Focus();
	}
	protected void txtName_TextChange(object sender, EventArgs e)
	{
		if (txtName.Text == "leaf")
		{
			lblValidate.Text = "用户名已占用!";
		}
		else
		{
			lblValidate.Text = "√";
		}
	}
}