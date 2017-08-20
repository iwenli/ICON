// Code are under MIT License
// http://ciconlibrary.codeplex.com/license
// Copyright (c) 2014 Jonathan Magnan. All rights reserved.
// http://www.zzzportal.com
//
// All icons are licensed under a Creative Commons Attribution 3.0 License.
// http://creativecommons.org/licenses/by/3.0/us/
// Copyright 2009-2013 FatCow Web Hosting. All rights reserved.
// http://www.fatcow.com/free-icons
//www.51aspx.com
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;

public static partial class IconExtension
{
    /// <summary>
    ///     An Icon extension method that get the 16x16 Icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 16x16 Icon.</returns>
    public static Icon GetIcon16(this  Z.IconLibrary.Icon @this)
    {
        Type enumType = typeof (Z.IconLibrary.Icon);
        Assembly assembly = enumType.Assembly;
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Z.IconLibrary.Icon16." + path;
            using (Stream stream = assembly.GetManifestResourceStream(assemblyResourceName))
            {
                var bipmap = new Bitmap(stream);
                return Icon.FromHandle(bipmap.GetHicon());
            }
        }
        return null;
    }

    /// <summary>
    ///     An Icon extension method that get the 32x32 Icon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The 32x32 Icon.</returns>
    public static Icon GetIcon32(this Z.IconLibrary.Icon @this)
    {
        Type enumType = typeof (Z.IconLibrary.Icon);
        Assembly assembly = enumType.Assembly;
        FieldInfo fi = enumType.GetField(@this.ToString());
        var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);

        if (attributes.Length > 0)
        {
            string path = attributes[0].Description;
            string assemblyResourceName = "Z.IconLibrary.Icon32." + path;

            using (Stream stream = assembly.GetManifestResourceStream(assemblyResourceName))
            {
                var bipmap = new Bitmap(stream);
                return Icon.FromHandle(bipmap.GetHicon());
            }
        }
        return null;
    }
}