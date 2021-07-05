let Account = require("./account");
let Emailer = require("./emailer");
let Logger = require("./logger");


let account = new Account();

account.deposit(1000);
account.withdraw(100);

console.log("Balance " + account.balance);

let emailer = new Emailer();
let logger = new Logger();

account.subscribe(emailer.sendEmail);
account.subscribe(logger.log);

account.deposit(1000);
account.withdraw(50);

