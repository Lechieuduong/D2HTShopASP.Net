<%@ Page Title="Contact" Language="C#" EnableEventValidation="false" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="D2HTShop.contact"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-contact">
            <span class="big-circle"></span>
            <img src="./images/shape.png" class="square" alt="" />
            <div class="form">
              <div class="contact-info">
                <h3 class="contact-title">Let's get in touch</h3>
                <p class="text">
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Saepe
                  dolorum adipisci recusandae praesentium dicta!
                </p>
      
                <div class="info">
                  <div class="information">
                    <img src="./images/location.png" class="icon" alt="" />
                    <p>96 Dinh Cong, Hoang Mai, Ha Noi</p>
                  </div>
                  <div class="information">
                    <img src="./images/email.png" class="icon" alt="" />
                    <p>lorem@ipsum.com</p>
                  </div>
                  <div class="information">
                    <img src="./images/phone.png" class="icon" alt="" />
                    <p>123-456-789</p>
                  </div>
                </div>
      
                <div class="social-media">
                  <p>Connect with us :</p>
                  <div class="social-icons">
                    <a href="#">
                      <i class="fab fa-facebook-f"></i>
                    </a>
                    <a href="#">
                      <i class="fab fa-twitter"></i>
                    </a>
                    <a href="#">
                      <i class="fab fa-instagram"></i>
                    </a>
                    <a href="#">
                      <i class="fab fa-linkedin-in"></i>
                    </a>
                  </div>
                </div>
              </div>
      
              <div class="contact-form">
                <span class="circle one"></span>
                <span class="circle two"></span>
      
                <form class="contact-form" action="index.html" autocomplete="off">
                  <h3 class="contact-title">Contact us</h3>
                  <div class="input-container">
                    <input type="text" name="name" class="input" />
                    <label for="">Username</label>
                    <span>Username</span>
                  </div>
                  <div class="input-container">
                    <input type="email" name="email" class="input" />
                    <label for="">Email</label>
                    <span>Email</span>
                  </div>
                  <div class="input-container">
                    <input type="tel" name="phone" class="input" />
                    <label for="">Phone</label>
                    <span>Phone</span>
                  </div>
                  <div class="input-container textarea">
                    <textarea name="message" class="input"></textarea>
                    <label for="">Message</label>
                    <span>Message</span>
                  </div>
                  <input type="submit" value="Send" class="btn-contact" />
                </form>
              </div>
            </div>
          </div>
        
    <!-- JS-->
    <script>
        var MenuItems = document.getElementById("MenuItems");
        MenuItems.style.maxHeight = "0px";

        function menutoggle() {
            if (MenuItems.style.maxHeight == "0px") {
                MenuItems.style.maxHeight = "300px";
            } else {
                MenuItems.style.maxHeight = "0px";
            }
        }

        const inputs = document.querySelectorAll(".input");

        function focusFunc() {
            let parent = this.parentNode;
            parent.classList.add("focus");
        }

        function blurFunc() {
            let parent = this.parentNode;
            if (this.value == "") {
                parent.classList.remove("focus");
            }
        }

        inputs.forEach((input) => {
            input.addEventListener("focus", focusFunc);
            input.addEventListener("blur", blurFunc);
        });


        function search() {
            var searchBox = document.querySelector('.search-box');
            if (searchBox.style.display == "none") {
                searchBox.style.display = "block";
            } else {
                searchBox.style.display = "none";
            }

        }
    </script>
</asp:Content>

