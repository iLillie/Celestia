import { defineStore } from "pinia";
import {mande} from "mande";
import {Folder} from "~/types";

const api = mande('http://localhost:5001/api/Folder');

export const useFolders = defineStore('folders', {
    state: () => ({
       folders: [],
    }),
    actions: {
        async getFolder(id: number) {
            this.folders.push(await api.get(id));
        },
        async getAllJFolder() {
            this.folders = await api.get("");
        },
        async updateFolder(id: number, folder: Folder) {
            await api.put(id, folder);
        },
        async newFolder(folder: Folder) {
            this.folders.push(await api.post(folder));
        },
        async deleteFolder(id: number) {
            await api.delete(id);
        }
    }
})
