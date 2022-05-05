"use strict";
exports.__esModule = true;
var namespaces_1 = require("./namespaces");
var cs = require("CustomModule");
var greeter = new namespaces_1.Greater('Miau miau');
greeter.greet();
var test = cs.fn();
