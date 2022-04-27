<%@ Page Title="Main" Language="C#" EnableEventValidation="false" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="product-detail.aspx.cs" Inherits="D2HTShop.product_detail"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<form runat="server">
    <!-- Single product details -->
        <div class="small-container single-product">
            <div class="row">
                
                    <div class="col-2">
                            <asp:Image ID="productImg" runat="server" CssClass="" Width="100%" />

                        <div class="small-img-row">
                            <div class="small-img-col">
                                <img src="./images/laptop7.png" width="100%" class="small-img">
                            </div>
                            <div class="small-img-col">
                                <img src="./images/laptop5.png" width="100%" class="small-img">
                            </div>
                            <div class="small-img-col">
                                <img src="./images/laptop9.png" width="100%" class="small-img">
                            </div>
                        </div>
                    </div>
                

                    <div class="col-2">
                        <p> <a href="index.aspx">Home</a> / Laptop</p>
                        <h1><asp:Label ID="name" runat="server" Text="Label"></asp:Label></h1>
                        <h4>$<asp:Label ID="price" runat="server" Text="Label"></asp:Label></h4>
                        <input type="number" value="1" name="number" runat="server" id="quantity" min="0">
                        
                        <!--<select>
                            <option>Select Color</option>
                            <option>Silver</option>
                            <option>Gold</option>
                            <option>Titan</option>
                            
                        </select>-->
                        
                        <asp:Button ID="btnthem" runat="server" CommandArgument='<%# Eval("id") %>' CssClass="btn" OnClick="btnthem_Click" Text="Add to Cart" style="width: 165px; cursor: pointer" OnClientClick="addToCart()"/>
                        
                        <h3>Product Details <span class="ti-menu-alt"></span></h3>
                        <br>
                        <p><asp:Label ID="details" runat="server" Text="Label"></asp:Label></p>
                    </div>

               
            </div>
        </div>

<!--Title-->
        <div class="small-container">
            <div class="row row-2">
                <h2>Related Products</h2>
                <p>View More</p>
            </div>
        </div>
<!--Product-->

        <div class="small-container">
        
            <div class="row">
                <div class="col-4">
                    <img src="./images/laptop4.png"/>
                    <h4>MacBook Pro 2022</h4>
                    <p>$500</p>
                </div>
    
                <div class="col-4">
                    <img src="./images/laptop5.png"/>
                    <h4>MacBook Pro 2022</h4>
                    <p>$500</p>
                </div>
    
                <div class="col-4">
                    <img src="./images/laptop6.png"/>
                    <h4>MacBook Pro 2022</h4>
                    <p>$500</p>
                </div>
            </div>
        </div>
 </form>
    <!-- JS-->
    <script>
        //Menu
        var MenuItems = document.getElementById("MenuItems");
        MenuItems.style.maxHeight = "0px";

        function menutoggle() {
            if (MenuItems.style.maxHeight == "0px") {
                MenuItems.style.maxHeight = "200px";
            } else {
                MenuItems.style.maxHeight = "0px";
            }
        }

        //Prouduct Galery
        var productImg = document.getElementById("productImg");
        var smallImg = document.getElementsByClassName("small-img");

        smallImg[0].onclick = function () {
            productImg.src = smallImg[0].src;
        }
        smallImg[1].onclick = function () {
            productImg.src = smallImg[1].src;
        }
        smallImg[2].onclick = function () {
            productImg.src = smallImg[2].src;
        }

        function search() {
            var searchBox = document.querySelector('.search-box');
            if (searchBox.style.display == "none") {
                searchBox.style.display = "block";
            } else {
                searchBox.style.display = "none";
            }
        }

        function addToCart() {
            alert("Add to cart successed!");
        }

    </script>
</asp:Content>


