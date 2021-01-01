<html>
<head>
<link rel="stylesheet" type="text/css" href="code.css"/>
</head>
<body>
<center>
<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('Could not connect to database :-'.mysql_error());
}
mysql_select_db("university",$con);
$result=mysql_query("Select * from admission where reg_no=('$_POST[regno]')");
$num_rows=mysql_num_rows($result);
if($num_rows>=1)
{
echo"<table border='1' align='center'>
<tr>
<th>Registration Number</th>
<th>Candidate's Name</th>
<th>Father's Name</th>
<th>Mother's Name</th>
<th>Current Address</th>
<th>Permenant Address</th>
<th>Land Phone Number</th>
<th>Mobile Number</th>
<th>Guardian's Phone Number</th>
<th>Guardian's Occupation</th>
<th>Marks in Madhyamik</th>
<th>Marks in H.S.</th>
<th>Marks in Graduate</th>
<th>Marks in Post Graduate</th>
</tr>";
while($rows=mysql_fetch_array($result))
{
echo"<tr>";
echo"<td align=center>".$rows['reg_no']."</td>";
echo"<td align=center>".$rows['name']."</td>";
echo"<td align=center>".$rows['father_name']."</td>";
echo"<td align=center>".$rows['mother_name']."</td>";
echo"<td align=center>".$rows['address']."</td>";
echo"<td align=center>".$rows['per_address']."</td>";
echo"<td align=center>".$rows['land_ph']."</td>";
echo"<td align=center>".$rows['mobile_ph']."</td>";
echo"<td align=center>".$rows['guardians_ph']."</td>";
echo"<td align=center>".$rows['guardians_occupation']."</td>";
echo"<td align=center>".$rows['student_mp']."</td>";
echo"<td align=center>".$rows['student_hs']."</td>";
echo"<td align=center>".$rows['student_gra']."</td>";
echo"<td align=center>".$rows['student_post']."</td>";
echo"</tr>";
}
echo"</table>";
echo"<form method='post' action='update.php'>
<fieldset align='center'>
<legend>EDIT DATA</legend>
<table height='100%' width='100%'>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Registration No. :-</b><input type='text' name='regno' style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt'></td>
</tr>
<tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Candidate's Name :-</b><input type='text' name='cname' style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Father's Name :-</b><input type='text' name='fname' style='position:absolute; left:250px; height:30px; width:400px;  font-size:14pt;'></td>
</tr>
<tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Mother's Name :-</b><input type='text' size='50' name='mname'  style='position:absolute; left:250px; font-size:14pt;'></td>
</tr>
<tr bgcolor='lightblue' height='150px'>
<td align='left'><b style='font-size:16px;'>Current Address :-</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<textarea name='address'  cols=80' rows='5' style='font-size:14pt;'></textarea></td>
</tr>
<tr bgcolor='white' height='150px'>
<td align='left'><b style='font-size:16px;'>Permenant Address :-</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<textarea name='paddress' cols=80' rows='5' style='font-size:14pt;'></textarea></td>
</tr>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Land Phone No. :-</b><input type='text' name='lphone'  style='position:absolute; left:250px; height:30px; width:400px;  font-size:14pt;'></td>
</tr>
<tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Mobile No. :-</b><input type='text' name='mobile' style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Guardian's Phone No. :-</b><input type='text' name='gphone'  style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Guardian's Occupation :-</b><input type='text' name='occu'  style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Marks in Madhyamik :-</b><input type='text' name='madhyamik'  style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr><tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Marks in Higher Secondary :-</b><input type='text' name='hs'  style='position:absolute; left:250px; height:30px; width:400px;  font-size:14pt;'></td>
</tr>
<tr bgcolor='lightblue' height='50px'>
<td align='left'><b style='font-size:16px;'>Marks in Graduate :-</b><input type='text' name='graduate'  style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='white' height='50px'>
<td align='left'><b style='font-size:16px;'>Marks in Post Graduate :-</b><input type='text' name='pg'  style='position:absolute; left:250px; height:30px; width:400px; font-size:14pt;'></td>
</tr>
<tr bgcolor='lightgreen' height='50px'>
<td><center><input id='button' type='submit' name='submit' value='Update' style='background-color:seagreen;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input id='button' type='reset' value='Reset'  style='background-color:seagreen;'></td>
</tr>
</table>
</form>";
}
else
{
echo"<h1>"."Sorry no record found"."</h1>";
}
mysql_close($con);
?>
</center>
</body>
</html>
