// import { Buyer } from '../Domain/Roles/Buyer';
// import { BuyerRepository } from '../Infrastructure/BuyerRepository';
var buyers = [
    {
        Email: 'email1@gmail.com',
        FirstName: 'Eugen',
        LastName: 'Popescu',
        Gender: 'M',
        Password: '123'
    },
    {
        Email: 'alexandra.ionescu@gmail.com',
        FirstName: 'Alexandra',
        LastName: 'Ionescu',
        Gender: 'F',
        Password: '12334'
    },
    {
        Email: 'maria.ariana@gmail.com',
        FirstName: 'Maria',
        LastName: 'Ionescu',
        Gender: 'F',
        Password: '12364'
    },
    {
        Email: 'claudiu.ion@gmail.com',
        FirstName: 'Claudiu',
        LastName: 'Ion',
        Gender: 'M',
        Password: '1234'
    },
];
var Buyer = /** @class */ (function () {
    function Buyer() {
        this.Confirmed = false;
        this.Balance = 0.0;
    }
    return Buyer;
}());
var BuyerRepository = /** @class */ (function () {
    function BuyerRepository() {
        var _this = this;
        this.GetBuyers = function () { return _this.Buyers; };
        this.Buyers = new Array();
    }
    BuyerRepository.prototype.createBuyer = function (buyer) {
        if (buyer) {
            this.Buyers.push(buyer);
            console.log("".concat(buyer.FirstName, " welcome in club!"));
        }
        else {
            console.log('Complete all required properties');
        }
    };
    BuyerRepository.prototype.deleteBuyer = function (buyer) {
        var index = this.Buyers.indexOf(buyer, 0);
        if (index > -1) {
            this.Buyers.splice(index, 1);
            console.log('Buyer was added successfully');
        }
        else {
            console.log("This buyer doesn't exists!");
        }
    };
    BuyerRepository.prototype.loginBuyer = function (Email, Password) {
        var returnResult = '';
        this.Buyers.forEach(function (e) {
            if (e.Email === Email && e.Password === Password) {
                returnResult = "Hello, ".concat(e.FirstName);
                return;
            }
            else {
                returnResult = "Email or Password incorrect!";
            }
        });
        return returnResult;
    };
    return BuyerRepository;
}());
var buyerRepo = new BuyerRepository();
buyers.forEach(function (e) {
    buyerRepo.createBuyer(e);
});
console.log(buyerRepo.loginBuyer('claudiu.ion@gmail.com', '1234'));
