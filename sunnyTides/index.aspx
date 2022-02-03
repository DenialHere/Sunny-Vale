<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="sunnyTides.index"  MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet"/>
    <script src="https://unpkg.com/aos@2.3.1/dist/aos.js"></script>
    <script>
    AOS.init();
    </script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-uWxY/CJNBR+1zjPWmfnSnVxwRheevXITnMqoEIeG1LJrdI0GlVs/9cVSyPYXdcSF" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-kQtW33rZJAHjgefvhyyzcGF3C5TFyBQBA13V1RKPf4uH+bwyzQxZ6CmMZHmNBEfJ" crossorigin="anonymous"></script>
    <title></title>
    <style>
        body {
            background-image: linear-gradient(to right, #b6432e, #e17946, #b6432e);
            font-family:  "Source Sans Pro", sans-serif;
            font-size:16px;
           
}
        .center {
            text-align:center;
        }
        .testimonial {
            height: 110px;
        }
        .image {
           box-shadow: 5px 10px;
           margin-bottom: 20px;
           display:inline;
        }
        .table {
            padding-top: 0px;
            border-color:black;
            
        }
        .btn {
            border-radius: 5px;
            color:white;
            padding:10px;
        }
        .logo {
            
        }
        li {
            display:inline;
        }
        .nav {
            text-decoration:none;
            list-style:none;
            align-items:stretch;
        }
        .headers {
            color:white;
            margin-top: 20px;
            margin-bottom: 20px;
        }
        .para {
            margin-left: auto;
            margin-right: auto;
            width: auto;
            display:block;
            width:100%;
            border: 5px solid black;
        }
        .centered {
            position: relative;
            display: inline-block;
        }
        .textImage {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate( -50%, -50% );
            color:white;
            font-size:1.5em;
            text-align:center;
            font-weight:bold;
            
        }
        img {
            display:block;
        }
    </style>
</head>
<body>

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
        
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr /> class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled">Disabled</a>
        </li>
      </ul>
      <form class="d-flex">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"> /
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>

    <h1 class="center headers fw-bold">What's SunnyVale like?</h1>
    <p class="centered textImage " >in SunnyVale, you'll find that people are friendly and open-minded. You'll also find that it's the perfect place to raise a family. Our clean air and safe streets are just two of the many reasons why so many people love it here so much. We have all the amenities you could ever want. Check out our new mall!</p>
    <img src="photos/SunnyValeMountain.jpg" alt="SunnyVale Mountains" class="para" height="700px" />
    <h1 class="center headers fw-bold">What do the people think of SunnyVale?</h1>
    <h4 class="center headers fw-bold">Meet Some of our residents and see what they have to say about SunnyVale!</h4>
    <form id="form1" runat="server" href="#jump">

            

             
          

            
        
             
            <asp:Table ID="Table2" runat="server" HorizontalAlign="Center" CellSpacing="8" CellPadding="2" Font-Bold="False" Width="200px" CssClass="table">

            <asp:TableHeaderRow runat="server">
             <asp:TableHeaderCell HorizontalAlign="center" ColumnSpan="2" >
                  <asp:Image ID="Image1" runat="server"  CssClass="image" Height="376px" Width="376" BorderColor="Black" BorderStyle="Solid"/>
             </asp:TableHeaderCell>
             
             </asp:TableHeaderRow>



             <asp:TableHeaderRow runat="server">
             <asp:TableHeaderCell HorizontalAlign="left">Name:</asp:TableHeaderCell>
             <asp:TableCell ID="name" HorizontalAlign="right" ></asp:TableCell>
             
             </asp:TableHeaderRow>

             <asp:TableHeaderRow runat="server" >
             <asp:TableHeaderCell HorizontalAlign="left">Age:</asp:TableHeaderCell>
             <asp:TableCell ID="age" HorizontalAlign="right" ></asp:TableCell>
             
             
             </asp:TableHeaderRow>

              <asp:TableHeaderRow runat="server" >
             <asp:TableHeaderCell HorizontalAlign="left">Status:</asp:TableHeaderCell>
             <asp:TableCell ForeColor="Green" HorizontalAlign="right"> Happy</asp:TableCell>
             </asp:TableHeaderRow>


             <asp:TableHeaderRow runat="server" >
             <asp:TableHeaderCell ColumnSpan="2" HorizontalAlign="center" CssClass="center">Testimonial:</asp:TableHeaderCell>
             </asp:TableHeaderRow>

             <asp:TableHeaderRow runat="server" >
             <asp:TableCell ID="testimonial" ColumnSpan="2" height="110" CssClass="center testimonial"></asp:TableCell>    
             </asp:TableHeaderRow>

              <asp:TableHeaderRow runat="server">
             <asp:TableHeaderCell HorizontalAlign="center" ColumnSpan="2" >
                  <asp:Button ID="btnNextPerson" Font-Bold="true"   runat="server" CssClass="btn btn-dark" Text="Next" OnClick="btnNextPerson_Click" BackColor="Black" Width="376"/>
             </asp:TableHeaderCell>
             
             </asp:TableHeaderRow>

             </asp:Table>
        
    </form>
</body>
</html>
