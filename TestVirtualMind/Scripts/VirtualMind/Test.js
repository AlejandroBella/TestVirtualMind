var Employee = function (name,lastName,salary) {
    this.name = name;
    this.lastName = lastName;
    this.salary = salary;
    // La siguiente línea es implícit y la añado solo para ilustrar el caso
    // this.__proto__ = Circle.prototype;
}

Employee.IncreaseSalary = function () {
    this.salary = salary + 1000;
}

Employee.ShowDetails = function () {
        console.log("Employe: " + this.name + " " + this.lastName);
        console.log("Salary: " + this.salary);
}


function Longest_Country_Name(params) {
    var max = "";
    for (i = 0; i < params.length; i++) {
        if(param[i].length>max.length)
        {
            max = param[i];
        }
    }
    return max;
}