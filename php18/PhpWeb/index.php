<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>MY PHP</title>
        <link rel="stylesheet" type="text/css" href="responsiveDemo.css" media="screen"/>
    </head>
    <body>
        <div id="main-container">
	<header>
		<h1>MY PHP PAGE </h1>
		
	</header>
	
	<div id="content">
		<img src="images/php.png" alt="SQL"/>
                <h2>HELPFUL LINK'S</h2>
		<p><a href="https://www.w3schools.com/php/default.asp">LINK ONE</a></p>
		<p><a href="https://www.w3schools.com/php/php_forms.asp">LINK TWO</a></p>
		<p><a href="https://www.w3schools.com/php/php_arrays_multi.asp"> LINK THREE</a></p>
                <h2> FIDEL'S GITHUB</h2>
                <p><a href="https://github.com/000214890/JSSummer2018">LINK</a></p>
                
	
	</div><!--/#content-->
	
	<aside>
		<h2>PHP LABS</h2>
		 <a href="Lab1.docx">LAB ONE</a> 
		
	</aside>
        <aside>
            <h2>PHP ZIPPED CODE</h2>
		<a href="Lab1.docx">LAB ONE</a> 
		
        </aside>
	
	<footer>
	 <?php
        $file = "index.php";
		$mod_date=date("F d Y h:i:s A", filemtime($file));
		echo "Last modified $mod_date";
        ?>
	
	</footer>

</div><!--/#main-container -->
</body>
       
    </body>
</html>
