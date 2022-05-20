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
            this.companies.push(await api.get(id));
        },
        async getAllCompanies() {
            this.companies = await api.get("");
        },
        async updateCompany(id: number, company: Company) {
            await api.put(id, company);
        },
        async newCompany(company: Company) {
            this.companies.push(await api.post(company));
        },
        async deleteCompany(id: number) {
            await api.delete(id);
        }
    }
})
