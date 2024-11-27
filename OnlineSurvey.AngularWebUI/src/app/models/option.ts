import { BaseEntity } from "./baseEntity";

export interface Option extends BaseEntity{
    pollId: number;
    optionText: string;
    voteCount: number;
}