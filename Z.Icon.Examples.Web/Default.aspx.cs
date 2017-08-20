// Code are under MIT License
// http://ciconlibrary.codeplex.com/license
// Copyright (c) 2014 Jonathan Magnan. All rights reserved.
// http://www.zzzportal.com
// 
// All icons are licensed under a Creative Commons Attribution 3.0 License.
// http://creativecommons.org/licenses/by/3.0/us/
// Copyright 2009-2013 FatCow Web Hosting. All rights reserved.
// http://www.fatcow.com/free-icons
using System;
using System.Web.UI;
using Z.IconLibrary;
//www.51aspx.com
namespace Z.Examples.Web
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.AddIconStyleSheet();

            if (!Page.IsPostBack)
            {
                uiCssClass16.CssClass = Icon.Accept.GetCssClass16(); // required web.config setup
                uiCssClass32.CssClass = Icon.Accept.GetCssClass32(); // required web.config setup

                uiUrl16.ImageUrl = Icon.Accept.GetUrl16(); // required web.config setup
                uiUrl32.ImageUrl = Icon.Accept.GetUrl32(); // required web.config setup

                uiWebResourceUrl16.ImageUrl = Icon.Accept.GetWebResourceUrl16(); // no requirement
                uiWebResourceUrl32.ImageUrl = Icon.Accept.GetWebResourceUrl32(); // no requirement

                uiIcon.DataSource = Enum.GetValues(typeof (Icon));
                uiIcon.DataBind();
            }

            uiIcon.SelectedIndexChanged += uiIcon_SelectedIndexChanged;
        }

        private void uiIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var icon = (Icon) Enum.Parse(typeof (Icon), uiIcon.SelectedValue);

            uiDynamicCssClass16.CssClass = icon.GetCssClass16();
            uiDynamicCssClass32.CssClass = icon.GetCssClass32();

            uiDynamicUrl16.ImageUrl = icon.GetUrl16();
            uiDynamicUrl32.ImageUrl = icon.GetUrl32();

            uiDynamicWebResourceUrl16.ImageUrl = icon.GetWebResourceUrl16();
            uiDynamicWebResourceUrl32.ImageUrl = icon.GetWebResourceUrl32();
        }
    }
}