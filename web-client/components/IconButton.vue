<template>
  <button :class="{ 'icon-shadow': hasShadow}"
          class="bg-slate-100 text-gray-900 text-lg p-1.5 leading-none rounded
          dark:bg-neutral-800 dark:text-gray-200
          dark:hover:text-gray-50 dark:hover:bg-neutral-900
          hover:bg-slate-50 hover:text-gray-800" @click="$emit('onClick')">
    <span :class="icon"></span>
  </button>
</template>

<script>
export default {
  name: "IconButton",
  props: {
    icon: '',
    onclick: {
      type: () => {
      }
    },
    hasShadow: false
  }
}
</script>

<style scoped>
.icon-shadow {
  box-shadow: 0px 0px 1px rgba(0, 0, 0, 0.2), 0px 0px 3px rgba(0, 0, 0, 0.05);
}
</style>
