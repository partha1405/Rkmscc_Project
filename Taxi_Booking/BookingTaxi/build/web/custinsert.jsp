<%-- 
    Document   : custinsert
    Created on : Jun 26, 2019, 10:53:37 AM
    Author     : Admin
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page language="java" import="java.sql.*"%>
 
                <%
                   
                    Connection con=null;
                    String url="jdbc:mysql://localhost:3306/";
                    String db="prtaxi";
                    String driver="com.mysql.jdbc.Driver";
                    String username="root";
                    Statement st;
                    Class.forName(driver).newInstance();
                    con=DriverManager.getConnection(url+db,username,"");
                    st=con.createStatement();
                    String cust_id=request.getParameter("cid");
                      String cust_name=request.getParameter("cnm");
                       String cust_address=request.getParameter("cads");
                       String cust_ph=request.getParameter("cph");
                        String cust_pan=request.getParameter("cpan");
                         String cust_adhar=request.getParameter("cadhar");
                         if(cust_id!=null)
                         st.executeUpdate("insert into customer(cust_id,cust_name,cust_address,cust_ph,cust_pan,cust_adhar) values('" +cust_id+ "','" +cust_name+ "','" +cust_address+ "','" +cust_ph+ "','" +cust_pan+ "','" +cust_adhar+ "')");
                    
                     
                %>
 <%--
                    Connection conx=null;
                    String urlx="jdbc:mysql://localhost:3306/";
                    String dbx="prtaxi";
                    String driverx="com.mysql.jdbc.Driver";
                    String usernm="root";
                    Statement stat;
                    Class.forName(driverx).newInstance();
                    conx=DriverManager.getConnection(urlx+dbx,usernm,"");
                    stat=conx.createStatement();
                     String sqlx="select max(cust_id)+1 from customer";
                     ResultSet res=stat.executeQuery(sqlx);
                      --%> 
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="newcss.css" rel="stylesheet" type="text/css"/>
        <script>
            function validate(){
                var z=document.forms["myform"]["cph"];
                if(!/^[0-9]+$/.test(z)){
                alert("Please enter number only");
                }
            }
            </script>
    </head>
    <body>
         <div style="background-color: cyan;">
           <p>
            <div class="dropdown">
                <button class="dropbtn">CUSTOMER DETAIL</button>
                <div class="dropdown-content">
                    <a href="custinsert.jsp">Customer Registration</a>
                    <a href="custdisplay.jsp">Search Customer</a>
                </div>
            </div>
                <div class="dropdown">
                <button class="dropbtn">Driver DETAIL</button>
                <div class="dropdown-content">
                    <a href="">Driver Registration</a>
                    <a href="">Search Driver</a>
                </div>
            </div>
            <div class="dropdown">
                <button class="dropbtn">CUSTOMER DETAIL</button>
                <div class="dropdown-content">
                    <a href="">Customer Registration</a>
                    <a href="">Search Registration</a>
                </div>
            </div>
        </p>
    </div>
         <center><fieldset style="width:500px;">
            <legend><h4><b>New Customer Registration</b></h4></legend>
            <form method="post" action="custinsert.jsp" name="myform">
                <table width="70%">
                    
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Customer ID</td><td><input type="text" name="cid" style="width:120px; height:20px;" /></td>
                </tr>
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Customer Name</td><td><input type="text" name="cnm" style="width:400px; height:20px;"></td>
                </tr> 
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Address</td><td><input type="text" name="cads" style="width:800px; height:20px;"></td>
                </tr> 
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Phone No.</td><td><input type="text" name="cph" style="width:250px; height:20px;" onkeypress="if (isNaN(this.value + String.fromCharCode(event.keyCode)))return false;"></td>
                </tr> 
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Customer's PAN No.</td><td><input type="text" name="cpan" style="width:250px; height:20px;"></td>
                </tr> 
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Customer's AAdhaar No.</td><td><input type="text" name="cadhar" style="width:250px; height:20px;" onkeypress="if (isNaN(this.value + String.fromCharCode(event.keyCode)))return false;"></td>
                </tr>
                <tr bgcolor="white" height="40px">
                    <td colspan="2" align="center"><input type="submit" name="insert" value="SUBMIT" />
                </tr>
                </table>
            </form>
        </fieldset></center>
    </body>
</html>
