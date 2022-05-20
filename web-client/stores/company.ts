import { defineStore } from "pinia";
import {mande} from "mande";
import {Company} from "~/types";

const api = mande('http://localhost:5001/api/Company');

export const useCompanies = defineStore('companies', {
    state: () => ({
        companies: [],
    }),
    actions: {
        async getCompany(id: number) {
            return this.companies.push(await api.get(id));
        },
        async getAllCompanies() {
            return this.companies = await api.get("");
        },
        async updateCompany(id: number, company: Company) {
            return await api.put(id, company);
        },
        async newCompany(company: Company) {
            return this.companies.push(await api.post(company));
        },
        async deleteCompany(id: number) {
            return await api.delete(id);
        }
    }
})
