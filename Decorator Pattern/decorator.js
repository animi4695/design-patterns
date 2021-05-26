function Macbook(){
    this.cost = function() { return 1000; };
    this.screenSize = function() { return 11.6; };
}

// Decorator 1
function Memory(macbook) {
    var v = macbook.cost();
    macbook.cost = function() {
        return v + 70;
    };
}

// Decorator 2
function Engraving(macbook) {
    var v = macbook.cost();
    macbook.cost = function() {
        return v + 10;
    };
}

// Decorator 3
function Insurance(mackbook) {
    var v = mackbook.cost();
    mackbook.cost = function(){
        return v + 100;
    };
}

var mb = new Macbook();
Memory(mb);
Engraving(mb);
Insurance(mb);

console.log(mb.cost());