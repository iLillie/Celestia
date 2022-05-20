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
            this.jobs.push(await api.get(id));
        },
        async getAllJobs() {
            this.jobs = await api.get("");
        },
        async updateJob(id: number, job: Job) {
            await api.put(id, job);
        },
        async newJob(job: Job) {
            this.jobs.push(await api.post(job));
        },
        async deleteJob(id: number) {
            await api.delete(id);
        }
    }
})
