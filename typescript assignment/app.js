"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const timers_1 = require("timers");
function greet(firstname, lastname) {
    console.log("Hello, " + firstname + " " + lastname);
}
greet("voleti Amal", "prathyusha");
//optional parameter function
function greeting(firstname, lastname) {
    console.log("Hello, " + firstname + " " + lastname);
}
greeting("voleti Amal");
//optional parameter with default value
function greetings(firstname, lastname = "prathyusha") {
    console.log("Hello, " + firstname + " " + lastname);
}
greetings("voleti Amal");
console.log('Hello world');
//arrow functions in typescript
class greeter {
    constructor() {
        this.firstname = "prathyusha";
    }
    sayhello() {
        timers_1.setTimeout(function () {
            console.log("hello, " + this.firstname);
        }, 50);
    }
}
let Greeter = new greeter();
Greeter.sayhello();
class employee {
}
//create variable
let emp = new employee();
emp.empid = 101;
emp.empname = "prathyusha";
console.log(emp.empid + " " + emp.empname);
class student {
}
let obj = new student();
obj.stname = "prathyusha";
obj.strollno = 2;
obj.stsection = "c";
obj.stregno = "17NM5A0432";
console.log(obj.stname + " " + obj.strollno + " " + obj.stsection + " " + obj.stregno);
//private
class Employee {
    constructor(ID, name) {
        this.empno = ID;
        this.empname = name;
    }
    display() {
        return "Employee ID: " + this.empno + " " + "Employee name:" + this.empname;
    }
}
let employees = new Employee(2, "prathyusha");
console.log(employees.display());
//protected
class students {
    constructor(ID, name) {
        this.stid = ID;
        this.stname = name;
    }
}
class person extends students {
    constructor(ID, name, department) {
        super(ID, name);
        this.department = department;
    }
    //object to call class
    GetResult() {
        return 'student ID:' + this.stid + " " + 'student name:' + this.stname + " " + 'student department:' + this.department;
    }
}
let jasmine = new person(101, "prathyusha", "ece");
console.log(jasmine.GetResult());
// Map and Set
let map = new Map(); //map have values and keys 
map.set(123, 'abc');
map.set(345, 'ghi');
map.set(true, false);
console.log(map); //Can contain duplicate values  but keys should be unique
let names = ['prathyusha', 'firdos', 'ramya', 'sravani', 'hema'];
names.push('ankitha');
let set = new Set(names); //Set have only values
console.log(names);
console.log(set); //Cannot contain duplicate values 
//generics
function getArray(items) {
    return new Array().concat(items);
}
let num = getArray([100, 200, 300]);
let str = getArray(["hello", "good", "morning"]);
num.push(500);
str.push("Prathyusha");
function displaytype(id, name) {
    console.log("type of id" + typeof (id) + "type of name" + typeof (name));
}
displaytype(1, "prathyu");
displaytype(2, "harshi");
class studentdetails {
    set(id, name) {
        this.id = id;
        this.name = name;
    }
    display() {
        console.log("id= " + this.id + "Name= " + this.name);
    }
}
let s = new studentdetails();
s.set(1, "harika");
s.display();
//loops
for (let i = 0; i < 8; i++) {
    console.log("loop statement." + i);
}
//modules
class Employeess {
}
exports.Employeess = Employeess;
var Organization;
(function (Organization) {
    class employees {
        constructor(name, Id, department) {
            this.name = name;
            this.Id = Id;
            this.department = department;
        }
    }
    Organization.employees = employees;
    class Department {
        constructor(DepartmentName) {
            this.DepartmentName = DepartmentName;
        }
    }
    Organization.Department = Department;
})(Organization || (Organization = {}));
let dept1 = new Organization.Department("IT");
let emp1 = new Organization.employees("harini", "218", dept1);
console.log(emp1);
//decorators
//class decorator
class perosns {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    showDetails() {
        return this.firstName + ", " + this.lastName;
    }
}
//method decorator
class ItemList {
    constructor() {
        this.itemArray = ["prathyusha", "firdos"];
    }
    Add(item) {
        this.itemArray.push(item);
    }
    GetAll() {
        return this.itemArray;
    }
}
//property decorator
class Company {
    constructor() {
        this.name = "HELLO";
    }
}
let company = new Company();
console.log(company.name);
//# sourceMappingURL=app.js.map