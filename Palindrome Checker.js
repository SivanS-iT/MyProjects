
/* 
Return true if the given string is a palindrome. Otherwise, return false.

A palindrome is a word or sentence that's spelled the same way 
both forward and backward, ignoring punctuation, case, and spacing.
*/


function palindrome(str) {
    let patt = /[\W_]/g;
    let newStr = str.toLowerCase().replace(patt, "");
    console.log(newStr);
      
    let rev = newStr.split("").reverse().join("");
   
      if(rev === newStr)  return true;
  
      return false;
  
  
    }
  
     console.log(palindrome("eye24("));