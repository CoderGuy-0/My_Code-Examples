// this code lets you press buttons on keyboard to do different things.

document.onkeyup = function(KeyEvent) {
 if (KeyEvent.which == 76) {
 alert("M = reload website\nU = you pressed U\nY = you pressed Y");
	}
   else if (KeyEvent.which == 77) {
    window.location.reload();
  } else if (KeyEvent.which == 66) {
  	alert("aaa");
  	}  
   else if (KeyEvent.which == 89) {
   alert("Y shortcut was pressed");
  } else if (KeyEvent.which == 85) {
    alert("U shortcut was pressed");
  }
  var key = KeyEvent.which || KeyEvent.keyCode;
}
