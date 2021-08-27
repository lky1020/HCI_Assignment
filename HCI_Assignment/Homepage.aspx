<%@ Page Language="C#" MasterPageFile="~/WAD.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="HCI_Assignment.Homepage" %>

<asp:Content ID="Homepage" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Background --%>
    <section class="banner" id="banner">
        <div class="content">
            <h2>Always Choose The Best</h2>
            <p>
                In the road to capture all the best moments in the life.
                The best moments in life always surround us, helping us, supporting us, and giving us strength.
            </p>
            <asp:Button ID="btnOurArtworks" runat="server" CssClass="btn" title="Visit Our Artwork Gallery" Text="Our ArtWorks" OnClick="btnViewAll_Click" causesvalidation="false" />
        </div>

        <video src="img/video/sky.mp4" muted loop autoplay></video>
    </section>
</asp:Content>
