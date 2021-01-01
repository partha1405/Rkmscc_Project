<html>
<body>
<?php
$con=mysql_connect("localhost","root");
if(!$con)
{
die('Could not connect to database :-'.mysql_error());
}
mysql_select_db("university",$con);
$result=mysql_query("Select * from login where userid=('$_POST[uid]') && password=('$_POST[pass]')");
$num_rows=mysql_num_rows($result);
if($num_rows>=1)
{
header('Location:inner.php');
}
else
{
echo"User ID or password is invalid";
header('Location:login.html');
}
?>
</body>
</html>