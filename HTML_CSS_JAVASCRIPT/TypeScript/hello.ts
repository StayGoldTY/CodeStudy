function sayHello(PersoneName:string|number[]){
    return 'Hello ' + PersoneName
}
let user = sayHello("Peter");
let usertwo = sayHello([1,2,3,4]);

let uservoid:void = null;
let usernull:null = undefined;
let userundefined :undefined = null;

function sayHellotwo():void{
    alert("sayHellotwo");
}

console.log(usertwo);

interface IPerson{
    Name:string;
    Age:number;
    Sex?:boolean;
    [propName:string]:string|number|boolean;
}

let userIn:IPerson ={
    Name:'Perter',
    Age:2,
    Sex: true,
    a:'a',
    b:'b',
    c:'c'
}
console.dir(userIn);

interface StringNumber{
    [index:number]:string
}
let sImple:StringNumber = ['1','2','3'];
console.log(sImple);