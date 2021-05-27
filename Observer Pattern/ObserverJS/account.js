class Account {
    // This is the subject, where everyone subscribes and unsubscribes
    constructor(){
        this.balance = 0;
        this.observers = [];
    }

    deposit(amount){
        this.balance += amount;
        this.notify();
    }

    withdraw(amount){
        if(amount <= this.balance){
            this.balance -= amount;
        }
        this.notify();
    }

    // adding observers
    subscribe(observer){
        this.observers.push(observer);
    }

    unsubscribe(observer){
        let index = this.observers.indexOf(observer, 0);
        if(index > -1 && observer == this.observers[index]){
            this.observers.splice(index, 1);
        }
        else{
            console.log("Observer Not Found");
        }
    }

    notify(){
        for(let i = 0; i < this.observers.length; i++){
            this.observers[i](this);
        }
    }
}

module.exports = Account;
// export default Account; // ES6 syntax