"use strict";
exports.__esModule = true;
exports.BuyerRepository = void 0;
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
    return BuyerRepository;
}());
exports.BuyerRepository = BuyerRepository;
