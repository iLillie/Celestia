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
            if(this.folders.findIndex(f => f.id === id) == -1) {
                return this.folders.push(await api.get(id));
            }
        },
        async getAllJFolder() {
            return this.folders = await api.get("");
        },
        async updateFolder(id: number, folder: Folder) {
            return await api.put(id, folder);
        },
        async newFolder(folder: Folder) {
            return this.folders.push(await api.post(folder));
        },
        async deleteFolder(id: number) {
            return await api.delete(id);
        }
    }
})

