<%@ Page Title="Main" Language="C#" EnableEventValidation="false" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="D2HTShop.index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-2" style="padding-left: 45px; padding-right: 45px">
            <h1>Make your wolrd become
                <br />
                more modern</h1>
            <p>Technology will change your life, change our future.</p>
            <a href="products.aspx" class="btn">Explore Now &#8594</a>
        </div>
        <div class="col-2" style="padding-left: 45px; padding-right: 45px">
            <img src="./images/willian-justen-de-vasconcellos-hPcF0UCpNhs-unsplash.jpg" />
        </div>
    </div>

    <!-- Fearured Categories -->
    <div class="categories">
        <div class="small-container">
            <div class="row">
                <div class="col-3">
                    <img src="images/laptop10.jpg" />
                </div>
                <div class="col-3">
                    <img src="images/macbook-pro-mini-led-2.png" />
                </div>
                <div class="col-3">
                    <img src="images/laptop11.jpg" />
                </div>
            </div>
        </div>
    </div>

    <!-- Fearured Products -->
    <div class="small-container">
        <h2 class="title">Feartured Products</h2>
        <div class="row">
            <asp:ListView ID="ListViewFearturedProducts" runat="server">
                <ItemTemplate>
                    <div class="col-4">
                        <a href="product-detail.aspx?id=<%# Eval("id") %>" title="ảnh laptop">
                            <img src="<%# Eval("img") %>" alt="ảnh laptop" /></a>
                        <h4><%# Eval("name") %></h4>
                        <p>$<%# Eval("price") %></p>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>

        <h2 class="title">Lastest Products</h2>
        <div class="row">
            <asp:ListView ID="ListViewLastestProducts" runat="server">
                <ItemTemplate>
                    <div class="col-4">
                        <a href="product-detail.aspx?id=<%# Eval("id") %>" title="ảnh laptop">
                            <img src="<%# Eval("img") %> " alt="ảnh laptop" /></a>
                        <h4><%# Eval("name") %></h4>
                        <p>$<%# Eval("price") %></p>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>

    <!-- Offer -->
    <div class="offer">
        <div class="small-container">
            <div class="row">
                <div class="col-2">
                    <img src="./images/laptop4.png" class="offer-img">
                </div>
                <div class="col-2">
                    <p>Exclusively Available on D2HTShop</p>
                    <h1>New Laptop</h1>
                    <small>Apple MacBook Air 2020 is a macOS laptop 
                            with a 13.30-inch display that has a 
                            resolution of 2560x1600 pixels. 
                            It is powered by a Core i3 processor 
                            and it comes with 8GB of RAM. 
                            The Apple MacBook Air 2020 packs 256GB 
                            of SSD storage. Graphics are powered
                             by Integrated Graphics Processor.
                    </small>
                    <a href="product-detail.aspx" class="btn">Buy Now &#8594;</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Brands -->
    <div class="brands">
        <div class="small-container">
            <div class="row">
                <div class="col-5">
                    <img src="./images/delllogo.png">
                </div>
                <div class="col-5">
                    <img src="./images/applelogo.png">
                </div>
                <div class="col-5">
                    <img src="./images/asuslogo.png">
                </div>
                <div class="col-5">
                    <img src="./images/predatorlogo.png">
                </div>
                <div class="col-5">
                    <img src="./images/lenovologo.png">
                </div>
            </div>
        </div>
    </div>

</asp:Content>
