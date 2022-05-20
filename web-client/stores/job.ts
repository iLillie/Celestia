import { defineStore } from "pinia";
import {mande} from "mande";
import {Job} from "~/types";

const api = mande('http://localhost:5001/api/Job');

export const useJobs = defineStore('jobs', {
    state: () => ({
       jobs: [],
    }),
    actions: {
        async getJob(id: number) {
            return this.jobs.push(await api.get(id));
        },
        async getAllJobs() {
            return this.jobs = await api.get("");
        },
        async updateJob(id: number, job: Job) {
            return await api.put(id, job);
        },
        async newJob(job: Job) {
            return this.jobs.push(await api.post(job));
        },
        async deleteJob(id: number) {
            return await api.delete(id);
        }
    }
})
