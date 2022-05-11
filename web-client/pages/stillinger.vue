<template>
  <main class="p-8 grid main gap-8 content-start overflow-y-auto max-w-min">
    <AdvertItem v-for="advert in adverts" @openModal="OpenModal()" :advert="advert" :key="advert.id"></AdvertItem>
    <AdvertModal @closeModal="() => CloseModal()" v-if="modalOpen">
    </AdvertModal>
  </main>
</template>

<style>
body {
  background-color: #F7F7F8;
}

.main {
  justify-items: start;
  justify-content: start;
  grid-template-columns: 1fr 1fr 1fr 1fr;
}
</style>

<script lang="ts">
import Vue from 'vue'
import { mapMutations } from 'vuex'


export default Vue.extend({
  name: 'Stillinger',
  mounted() {
    if(this.adverts.length > 0) return;
  },
  computed: {
    adverts() {
      return this.$store.state.advert.adverts;
    }
  },
  data() {
    return {
      modalOpen: false
    }
  },
  methods: {
    OpenModal() {
      this.modalOpen = !this.modalOpen;
    },
    CloseModal() {
      this.modalOpen = false;
    }
  }
})
</script>
