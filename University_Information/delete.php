<html>
<body>
<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('Error : :'.mysql_error());
}
mysql_select_db("university",$con);
$sql="delete from admission where reg_no='$_POST[regno]'";
if(!mysql_query($sql,$con))
{
die('Error : :'.mysql_error());
}
echo"Record deleted successfully";
mysql_close($con);
?>
</body>
</html>