<%-- 
    Document   : custdisplay
    Created on : Jun 26, 2019, 10:56:45 AM
    Author     : Admin
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page language="java" import="java.sql.*"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
         <link href="newcss.css" rel="stylesheet" type="text/css"/>
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
            <legend><h4><b>Search Customer</b></h4></legend>
            <form method="post" action="custdisplay.jsp">
                 <table width="70%">
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Customer ID</td>
                    <td><input type="text" name="cid" style="width:120px; height:20px;"></td>
                    <td><input type="submit" name="search" value="SEARCH" /></td>
                </tr>
                </table>
            </fieldset></center>
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
                     String sql="select * from customer where cust_id='"+cust_id+ "'";
                     ResultSet rs=st.executeQuery(sql);
                     if(rs.next())
                     { %> 
                <center><fieldset style="width:500px;">
                <table width="70%">
                     <tr bgcolor="lightblue" height="40px">
                         <td align="left" width="15%">Customer ID</td><td><input type="text" name="custid" style="width:400px; height:20px;" value='<%=rs.getString(1)%>' readonly></td>
                </tr>
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Customer Name</td><td><input type="text" name="cnm" style="width:400px; height:20px;" value='<%=rs.getString(2)%>'></td>
                </tr> 
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Address</td><td><input type="text" name="cads" style="width:800px; height:20px;" value='<%=rs.getString(3)%>'></td>
                </tr> 
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Phone No.</td><td><input type="text" name="cph" style="width:250px; height:20px;" value='<%=rs.getString(4)%>'></td>
                </tr> 
                <tr bgcolor="lightblue" height="40px">
                    <td align="left" width="15%">Customer's PAN No.</td><td><input type="text" name="cpan" style="width:250px; height:20px;" value='<%=rs.getString(5)%>'></td>
                </tr> 
                <tr bgcolor="white" height="40px">
                    <td align="left" width="15%">Customer's AAdhaar No.</td><td><input type="text" name="cadhar" style="width:250px; height:20px;" value='<%=rs.getString(6)%>'></td>
                </tr>
                 <tr bgcolor="white" height="40px">
                    <td colspan="2" align="center"><input type="submit" name="update" value="UPDATE" />
                    <td colspan="2" align="center"><input type="submit" name="delete" value="DELETE" />
            </tr>
                </table>
                 <% }%>
            </form>
        </fieldset></center>
          
    </body>
</html>
 <%
    
                   if(request.getParameter("update")!=null)
                   {
                     Connection conx=null;
                    String urlx="jdbc:mysql://localhost:3306/";
                    String dbx="prtaxi";
                    String driverx="com.mysql.jdbc.Driver";
                    String usernm="root";
                    Statement stat;
                    Class.forName(driverx).newInstance();
                    conx=DriverManager.getConnection(urlx+dbx,usernm,"");
                    stat=conx.createStatement();
                    String cst_id=request.getParameter("custid");
                      String cust_name=request.getParameter("cnm");
                       String cust_address=request.getParameter("cads");
                       String cust_ph=request.getParameter("cph");
                        String cust_pan=request.getParameter("cpan");
                         String cust_adhar=request.getParameter("cadhar");
                         if(cst_id!=null)
                         {
                         stat.executeUpdate("update customer set cust_name='" +cust_name+ "',cust_address='" +cust_address+ "',cust_ph='" +cust_ph+ "',cust_pan='" +cust_pan+ "',cust_adhar='" +cust_adhar+ "' where cust_id='" +cst_id+ "'");
                         out.println("Record updated");
                         }
                        
                   } 
                   else if(request.getParameter("delete")!=null){
                    Connection cond=null;
                    String urld="jdbc:mysql://localhost:3306/";
                    String dbd="prtaxi";
                    String driverd="com.mysql.jdbc.Driver";
                    String usernmd="root";
                    Statement statd;
                    Class.forName(driverd).newInstance();
                    cond=DriverManager.getConnection(urld+dbd,usernmd,"");
                    statd=cond.createStatement();
                    String cs_id=request.getParameter("custid");
                         if(cs_id!=null)
                         {
                         statd.executeUpdate("delete from customer where cust_id='" +cs_id+ "'");
                         out.println("Record deleted");
                         }
                   }  
                %>
                <%
                   
                     
                         
                     
                %>