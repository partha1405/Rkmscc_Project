<html>
<body>
<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('Error : :'.mysql_error());
}
mysql_select_db("university",$con);
$sql="update admission set name='$_POST[cname]',father_name='$_POST[fname]',mother_name='$_POST[mname]',address='$_POST[address]',per_address='$_POST[paddress]',land_ph='$_POST[lphone]',mobile_ph='$_POST[mobile]',guardians_ph='$_POST[gphone]',guardians_occupation='$_POST[occu]',student_mp='$_POST[madhyamik]',student_hs='$_POST[hs]',student_gra='$_POST[graduate]',student_post='$_POST[pg]' where reg_no='$_POST[regno]'";
if(!mysql_query($sql,$con))
{
die('Error : :'.mysql_error());
}
echo"Record updated successfully,";
mysql_close($con);
?>
</body>
</html>