import { BaseEntity } from "./baseEntity";

export interface Poll extends BaseEntity{
    title: string,
    userName: string,
    options: string[]
}
