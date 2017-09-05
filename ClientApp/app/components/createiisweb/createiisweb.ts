import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

@inject(HttpClient)
export class CreateIISWeb {
    public appName: string;

    constructor() {

    }

    sayHello() {
        alert(`Hello Nice to meet you.`);
    }

}