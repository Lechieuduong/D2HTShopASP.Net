<%@ Page Title="Profile" Language="C#" EnableEventValidation="false" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="userinformation.aspx.cs" Inherits="D2HTShop.userinformation" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div>
            <h2 style="text-align: center">Your Profile</h2>
        </div>

        <div class="wrapper">
            <div class="left">
                <img src="images/userprofile.jpg" alt="user" width="100">
                <h4 style="color: black" >Your name</h4>
                <input class="inputregister" type="text" runat="server" id="infoname" name="infoname" placeholder="Your Name" required="required" />
                <p style="color: black">Normal Account</p>
            </div>
        
            <div class="right">
                <div class="info">
                    <h3>Information</h3>
                        <div class="info_data">
                             <div class="data">
                                <h4>Email</h4>
                                <input  class="inputregister" type="email" runat="server" id="infoemail" name="infoemail" placeholder="Your Email" required="required" />
                             </div>
                             <div class="data">
                               <h4>Phone</h4>
                               <p>0918792787</p>
                             </div>
                        </div>
                </div>
      
            <div class="projects">
                <h3>Yourself</h3>
                    <div class="projects_data">
                        <div class="data">
                            <h4>Recent</h4>
                            <p>Lorem ipsum dolor sit amet.</p>
                        </div>
                        <div class="data">
                            <h4>Most Viewed</h4>
                            <p>dolor sit amet.</p>
                        </div>
                    </div>
            </div>

            <div class="social_media">
                <ul>
                    <li><a href="#"><i class="fab fa-facebook-f"></i></a></li>
                    <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                    <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                </ul>
            </div>
        </div>
    </div>

        <!--<input  type="submit" value="Save" class="btn" style="height: 40px"/>-->
        <br />
    <div class="col-2" style="text-align: center">
        
        <a href="index.aspx" class="btn" style="margin-right: 10px">Back to Home Page</a>
        <a href="logout.aspx" class="btn">Logout</a>
    </div>

    </form>
    
    <script>
        var dob = document.getElementById("dobRegister");
        var loi = document.getElementById("MainContent_loi");
        datenow = new Date();
        datedob = new Date(dob.value);
        if (datenow.getTime() < datedob.getTime()) {
            loi.innerText = "Vui lòng nhập đúng ngày sinh.bạn đang nhập ngày sinh lớn hơn ngày hiện tại";
            dob.focus();
            return false;
        }

    </script>
    
</asp:Content>

