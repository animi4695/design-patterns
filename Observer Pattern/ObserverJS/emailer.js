class Emailer {
    constructor() {

    }

    sendEmail(account){
        console.log("Sending Email... Balance :" + account.balance);
    }
}

module.exports = Emailer;
// export default Emailer;