<html>
<body>
<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('Error : :'.mysql_error());
}
mysql_select_db("university",$con);
$sql="insert into admission values('$_POST[regno]','$_POST[cname]','$_POST[fname]','$_POST[mname]','$_POST[address]','$_POST[paddress]','$_POST[lphone]','$_POST[mobile]','$_POST[gphone]','$_POST[occu]','$_POST[madhyamik]','$_POST[hs]','$_POST[graduate]','$_POST[pg]')";
if(!mysql_query($sql,$con))
{
die('Error : :'.mysql_error());
}
echo"Data inserted successfully";
mysql_close($con);
?>
</body>
</html>