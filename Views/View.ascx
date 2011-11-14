<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="View.ascx.cs" Inherits="WebFormsMvpModule.Views.View" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>

<!-- Include the necessary client resources for this control -->
<dnn:DnnJsInclude runat="server" FilePath="~/ClientResources/js/view.js" />
<dnn:DnnCssInclude runat="server" FilePath="~/ClientResources/css/common.css" />
<dnn:DnnCssInclude runat="server" FilePath="~/ClientResources/css/view.css" />
