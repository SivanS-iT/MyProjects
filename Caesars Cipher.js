
/*
One of the simplest and most widely known ciphers is a Caesar cipher, also known as a shift cipher. 
In a shift cipher the meanings of the letters are shifted by some set amount.

A common modern use is the ROT13 cipher, 
where the values of the letters are shifted by 13 places. Thus A ↔ N, B ↔ O and so on.

Write a function which takes a ROT13 encoded string as input and returns a decoded string.
*/


// [a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z]

function rot13(str) {
    var sol = "";
  
    for (var i = 0; i < str.length; i++) {
      var asci = str[i].charCodeAt();
  
      if (asci >= 65 && asci <= 77) {
        sol += String.fromCharCode(asci + 13);
      } else if (asci >= 78 && asci <= 90) {
        sol += String.fromCharCode(asci - 13);
      } else {
        sol += str[i];
      }
    }
    console.log(sol);
    return sol;
  }
  
  rot13("SERR CVMMN!");
  