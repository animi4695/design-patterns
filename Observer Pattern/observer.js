class Subject {
    constructor() {
        this.observers = [];
    }

    subscribe(fn){
        this.observers.push(fn);
    }

    unsubscribe(fnToRemove){
        this.observers = this.observers.filter(fn => {
            if(fn != fnToRemove){
                return fn;
            }
        })
    }

    fire(){
        this.observers.forEach(fn => {
            fn.call();
        });
    }
}

function ObserverTest(){
    console.log("Observer Test works");
}

function AnotherFunction() {
    console.log("Another Function works");
}

const subj = new Subject();

subj.subscribe(ObserverTest);
subj.subscribe(AnotherFunction);

subj.fire();

