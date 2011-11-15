<%@ Control Language="C#" CodeBehind="Settings.ascx.cs" Inherits="$Namespace$$safeprojectname$.Views.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/labelcontrol.ascx" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>

<!-- Include the necessary client resources for this control -->
<dnn:DnnJsInclude runat="server" FilePath="~/DesktopModules/$safeprojectname$/ClientResources/js/settings.js" />
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/$safeprojectname$/ClientResources/css/common.css" />
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/$safeprojectname$/ClientResources/css/settings.css" />

<div class="dnnForm" id="form-demo">
    <asp:Label runat="server" CssClass="dnnFormMessage dnnFormInfo" ResourceKey="Intro" />
    
    <div class="dnnFormItem dnnFormHelp dnnClear">
        <p class="dnnFormRequired"><asp:Label runat="server" ResourceKey="Required Indicator" /></p>
    </div>

    <fieldset>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="NameTextBox" ResourceKey="Name" />
            <asp:TextBox runat="server" ID="NameTextBox" CssClass="dnnFormRequired" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="NameTextBox" CssClass="dnnFormMessage dnnFormError" ResourceKey="Name.Required" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="DescriptionTextBox" ResourceKey="Description" />
            <asp:TextBox runat="server" TextMode="MultiLine" ID="DescriptionTextBox" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="ChoiceDropDown" ResourceKey="Choice" />
            <asp:DropDownList runat="server" ID="ChoiceDropDown">
                <asp:ListItem Text="-- Make a Choice --" />
                <asp:ListItem Text="First Choice" />
                <asp:ListItem Text="Second Choice" />
            </asp:DropDownList>
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="RateRadioButtons" ResourceKey="Rate" />
            <asp:RadioButtonList runat="server" ID="RateRadioButtons"
                RepeatDirection="Horizontal" RepeatLayout="Flow"
                CssClass="dnnFormRadioButtons">
                <asp:ListItem Text="1" />
                <asp:ListItem Text="2" />
                <asp:ListItem Text="3" />
                <asp:ListItem Text="4" />
                <asp:ListItem Text="5" />
            </asp:RadioButtonList>
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="AgreeCheckbox" ResourceKey="Agree" />
            <asp:CheckBox runat="server" ID="AgreeCheckbox" />
        </div>
    </fieldset>
</div>