/*
Design a cash register drawer function checkCashRegister() that accepts purchase price as the first argument (price), 
payment as the second argument (cash), and cash-in-drawer (cid) as the third argument.

Did is a 2D array listing available currency.

The checkCashRegister() function should always return an object with a status key and a change key.

Return {status: "INSUFFICIENT_FUNDS", change: []} if cash-in-drawer is less than the change due, 
or if you cannot return the exact change.

Return {status: "CLOSED", change: [...]} with cash-in-drawer as the value for the key change if it is equal to the change due.

Otherwise, return {status: "OPEN", change: [...]}, with the change due in coins and bills, 
sorted in highest to lowest order, as the value of the change key.
*/





function checkCashRegister(price, cash, cid) {
    let change = cash * 100 - price * 100;
    let cidTotal = 0;
    let moneyUnits = {
      "PENNY": 1,
      "NICKEL": 5,
      "DIME": 10,
      "QUARTER": 25,
      "ONE": 100,
      "FIVE": 500,
      "TEN": 1000,
      "TWENTY": 2000,
      "ONE HUNDRED": 10000
    }
  
  
    for (let key of cid) {
      cidTotal += key[1] * 100
  
    }
    if (change > cidTotal) {
      return { status: "INSUFFICIENT_FUNDS", change: [] }
    } else if (change === cidTotal) {
      return { status: "CLOSED", change: cid }
    } else {
      let losung = [];
      cid = cid.reverse();
  
      for (let key of cid) {
        let halter = [key[0], 0];
        key[1] *= 100;
  
        while (change >= moneyUnits[key[0]] && key[1] > 0) {
          change -= moneyUnits[key[0]];
          key[1] -= moneyUnits[key[0]];
          halter[1] += moneyUnits[key[0]] / 100;
  
        }
        if (halter[1] > 0) {
          losung.push(halter);
  
        }
      }
      if (change > 0) {
        return { status: "INSUFFICIENT_FUNDS", change: [] }
      }
      return { status: "OPEN", change: losung }
    }
  }
  
  console.log(checkCashRegister(3.26, 100, [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]]));
  
  /*  
  {status: "OPEN", change: [["TWENTY", 60], ["TEN", 20], ["FIVE", 15], ["ONE", 1], ["QUARTER", 0.5], ["DIME", 0.2], ["PENNY", 0.04]]}
  */